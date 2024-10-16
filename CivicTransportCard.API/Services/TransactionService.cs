using AutoMapper;
using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Entities;
using CivicTransportCard.Core.Enum;
using CivicTransportCard.Core.Models;
using CivicTransportCard.Data.Repositories.Interface;

namespace CivicTransportCard.API.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ITransportCardRepository _transportCardRepository;
        private readonly ITransactionLocationRepository _transactionLocationRepository;
        private readonly IMapper _mapper;
        public TransactionService(ITransportCardRepository transportCardRepository,
            ITransactionRepository transactionRepository,
            ITransactionLocationRepository transactionLocationRepository,
            IMapper mapper)
        {
            _transactionLocationRepository = transactionLocationRepository;
            _transactionRepository = transactionRepository;
            _transportCardRepository = transportCardRepository;
            _mapper = mapper;
        }
        public async Task<Transaction> UpsertTransaction(UpsertTripRequestContract upsertTripData)
        {
            //check if card is valid
            var transactionToReturn = new Transaction();
            var transportCard = await _transportCardRepository.GetTransportCardByCardNo(upsertTripData.CardNo);
            
            if (transportCard == null )
            {
                throw new ArgumentNullException();
            }
            if (transportCard.DateExpire <= DateTime.Now)
            {
                throw new ArgumentException($"Card expired since {transportCard.DateExpire.ToString("MM/dd/yyyy hh:mm tt")}.");
            }
            //get recent transaction and update, add if none
            var recentTransaction = await _transactionRepository.GetRecentTransportTransaction(transportCard.Id);
            var incompleteTrip = recentTransaction == null ? null : await _transactionLocationRepository.GetTransactionLocationByTransactionId(recentTransaction.Id);

            if (recentTransaction == null || incompleteTrip == null)
            {
                var toAddTransactionEntity = new TransactionEntity
                {
                    Id = Guid.NewGuid(),
                    TransportCardId = transportCard.Id,
                    Description = "Trip Transaction",
                    DateCreated = DateTime.Now,
                    Amount = await TransactionAmount(transportCard.CardType, upsertTripData.CardNo),
                    TransactionType = TransactionType.Transport,
                    EndingBalance = transportCard.Balance
                };
                transportCard.LastTransactionDate = toAddTransactionEntity.DateCreated;
                transportCard.DateExpire = toAddTransactionEntity.DateCreated
                                            .AddYears(transportCard.CardType == CardType.Civic_Transport ? 5 : 3);
                await _transportCardRepository.UpdateAsync(transportCard);
                await _transactionRepository.AddAsync(toAddTransactionEntity);

                var toAddTransactionLocation = new TransactionLocationEntity
                {
                    Id = Guid.NewGuid(),
                    EntryPointLocationId = upsertTripData.LocationId,
                    TransactionId = toAddTransactionEntity.Id
                };
                await _transactionLocationRepository.AddAsync(toAddTransactionLocation);
                transactionToReturn = _mapper.Map<Transaction>(toAddTransactionEntity);
            }
            else
            {
                if (incompleteTrip != null)
                {
                    transportCard.Balance -= recentTransaction.Amount;
                    recentTransaction.EndingBalance = transportCard.Balance;
                    incompleteTrip.ExitPointLocationId = upsertTripData.LocationId;
                    await _transportCardRepository.UpdateAsync(transportCard);
                    await _transactionRepository.UpdateAsync(recentTransaction);
                    await _transactionLocationRepository.UpdateAsync(incompleteTrip);
                }
                transactionToReturn = _mapper.Map<Transaction>(recentTransaction);
            }
            await _transportCardRepository.SaveChangesAsync();
            return transactionToReturn;
        }

        private async Task<decimal> TransactionAmount(CardType cardType, string cardNo)
        {
            decimal amount = 15;

            if (cardType == CardType.Civic_Discounted_Transport)
            {
                amount = 10;
            }
            else if (cardType == CardType.Civic_Discount_Definition)
            {
                var cardTransactionsToday = await _transactionLocationRepository.GetTransactionsByCardId(cardNo);

                if (cardTransactionsToday == null || cardTransactionsToday.Count == 0 || cardTransactionsToday.Count >= 5)
                {
                    amount *= 0.8m; // Apply 20% discount
                }
                else if (cardTransactionsToday.Count >= 1)
                {
                    amount *= 0.77m; // Apply 23% discount
                }
            }

            return amount;
        }


    }
}

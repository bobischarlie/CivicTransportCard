using AutoMapper;
using CivicTransportCard.API.Services.Interface;
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
        public async Task<Transaction> UpsertTransaction(string cardNo, Guid locationId)
        {
            //check if card is valid
            var transactionToReturn = new Transaction();
            var transportCard = await _transportCardRepository.GetTransportCardByCardNo(cardNo);
            if (transportCard == null)
            {
                throw new ArgumentNullException();
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
                    Amount = setTransactionAmount(),
                    TransactionType = TransactionType.Transport,
                    EndingBalance = transportCard.Balance
                };
                transportCard.LastTransactionDate = toAddTransactionEntity.DateCreated;
                await _transportCardRepository.UpdateAsync(transportCard);
                await _transactionRepository.AddAsync(toAddTransactionEntity);

                var toAddTransactionLocation = new TransactionLocationEntity
                {
                    Id = Guid.NewGuid(),
                    EntryPointLocationId = locationId,
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
                    incompleteTrip.ExitPointLocationId = locationId;
                    await _transportCardRepository.UpdateAsync(transportCard);
                    await _transactionRepository.UpdateAsync(recentTransaction);
                    await _transactionLocationRepository.UpdateAsync(incompleteTrip);
                }
            }
            _transportCardRepository.SaveChangesAsync();
            transactionToReturn = _mapper.Map<Transaction>(recentTransaction);
            return transactionToReturn;
        }

        private decimal setTransactionAmount()
        {
            return 15;
        }
    }
}

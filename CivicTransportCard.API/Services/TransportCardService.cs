using AutoMapper;
using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Entities;
using CivicTransportCard.Core.Enum;
using CivicTransportCard.Core.Models;
using CivicTransportCard.Data.Repositories.Interface;

namespace CivicTransportCard.API.Services
{
    public class TransportCardService : ITransportCardService
    {
        private readonly ITransportCardRepository _transportCardRespository;
        private readonly IMapper _mapper;
        private readonly ITransactionRepository _transactionResitory;
        public TransportCardService(ITransportCardRepository transportCardRepository, IMapper mapper, ITransactionRepository transactionResitory)
        {
            _transportCardRespository = transportCardRepository;
            _mapper = mapper;
            _transactionResitory = transactionResitory;
        }
        public async Task<TransportCard> AddNewTransportCardAsync(TransportCardRequestContract transportCardRequest)
        {
            var isDiscountedCard = transportCardRequest.CardType != CardType.Civic_Transport;
            var transportCardData = _mapper.Map<TransportCardEntity>(transportCardRequest);
            transportCardData.Id = Guid.NewGuid();
            transportCardData.LastTransactionDate = DateTime.Now;
            transportCardData.Balance = isDiscountedCard ? 500 : 300;
            transportCardData.DateExpire = transportCardData.LastTransactionDate.
                AddYears(isDiscountedCard ? 3 : 5);
            await _transportCardRespository.AddAsync(transportCardData);

            //Add Transaction For Registering Card
            var transactionEntity = new TransactionEntity()
            {
                Id = Guid.NewGuid(),
                Amount = transportCardData.Balance,
                DateCreated = transportCardData.LastTransactionDate,
                Description = "Registered the Card",
                EndingBalance = transportCardData.Balance,
                TransactionType = TransactionType.Register,
                TransportCardId = transportCardData.Id
            };
            await _transactionResitory.AddAsync(transactionEntity);
            await _transactionResitory.SaveChangesAsync();

            var returnTransportData = _mapper.Map<TransportCard>(transportCardData);
            return returnTransportData;
        }

        public async Task<TransportCard> ReloadCardAsync(ReloadCardRequestContract reloadRequest)
        {
            var transportCard = await _transportCardRespository.GetTransportCardByCardNo(reloadRequest.CardNo);
            var isDiscountedCard = transportCard.CardType != CardType.Civic_Transport;
            if (transportCard == null)
            {
                throw new ArgumentNullException();
            }
            if (transportCard.DateExpire <= DateTime.Now)
            {
                throw new ArgumentException($"Card expired since {transportCard.DateExpire.ToString("MM/dd/yyyy hh:mm tt")}.");
            }
            if ((transportCard.Balance + reloadRequest.LoadAmount) > 20000)
            {
                throw new ArgumentException($"Reloading Failed, 20000 is the max limit of the card," +
                    $" you can load up to {  20000 - transportCard.Balance} only.");
            }
            transportCard.DateExpire = DateTime.Now.AddYears(isDiscountedCard ? 3 : 5);
            transportCard.Balance += reloadRequest.LoadAmount;
            transportCard.LastTransactionDate = DateTime.Now;
            //Add Transaction For Reloading Card
            var transactionEntity = new TransactionEntity()
            {
                Id = Guid.NewGuid(),
                Amount = reloadRequest.LoadAmount,
                DateCreated = transportCard.LastTransactionDate,
                Description = "Reload Card",
                EndingBalance = transportCard.Balance,
                TransactionType = TransactionType.Reload,
                TransportCardId = transportCard.Id
            };
            await _transportCardRespository.UpdateAsync(transportCard);
            await _transactionResitory.AddAsync(transactionEntity);
            await _transactionResitory.SaveChangesAsync();
            var returnTransportCard = _mapper.Map<TransportCard>(transportCard);
            return returnTransportCard;
        }
    }
}

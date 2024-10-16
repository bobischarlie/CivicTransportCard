using AutoMapper;
using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Entities;
using CivicTransportCard.Core.Enum;
using CivicTransportCard.Core.Models;
using CivicTransportCard.Data.Repositories.Interface;

namespace CivicTransportCard.API.Services
{
    public class TransportCardService: ITransportCardService
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
            var transportCardData = _mapper.Map<TransportCardEntity>(transportCardRequest);
            transportCardData.Id = Guid.NewGuid();
            transportCardData.LastTransactionDate = DateTime.Now;
            transportCardData.Balance = 300;
            await _transportCardRespository.AddAsync(transportCardData);

            //Add Transaction For Registering Card
            var transactionEntity = new TransactionEntity()
            { 
                Amount = transportCardData.Balance, 
                DateCreated = transportCardData.LastTransactionDate, 
                Description = "Registered the Card", 
                EndingBalance = transportCardData.Balance, 
                Id= Guid.NewGuid(),
                TransactionType = TransactionType.Register,
                TransportCardId = transportCardData.Id
            };
            await _transactionResitory.AddAsync(transactionEntity);
            await _transactionResitory.SaveChangesAsync();

            var returnTransportData = _mapper.Map<TransportCard>(transportCardData);
            return returnTransportData;
        }
    }
}

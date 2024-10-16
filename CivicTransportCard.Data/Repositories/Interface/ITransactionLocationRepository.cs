using CivicTransportCard.Core.Entities;

namespace CivicTransportCard.Data.Repositories.Interface
{
    public interface ITransactionLocationRepository : IGenericRepository<TransactionLocationEntity>
    {
        Task<TransactionLocationEntity> GetTransactionLocationByTransactionId(Guid transactionId);
        Task<List<TransactionLocationEntity>> GetTransactionsByCardId(string cardNo);
    }
}

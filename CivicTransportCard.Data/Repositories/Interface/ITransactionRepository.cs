using CivicTransportCard.Core.Entities;

namespace CivicTransportCard.Data.Repositories.Interface
{
    public interface ITransactionRepository : IGenericRepository<TransactionEntity>
    {
        Task<TransactionEntity> GetRecentTransportTransaction(Guid transportCardId);
    }
}

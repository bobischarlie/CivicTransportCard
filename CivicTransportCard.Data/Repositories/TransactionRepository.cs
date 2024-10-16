using CivicTransportCard.Core.Entities;
using CivicTransportCard.Core.Enum;
using CivicTransportCard.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CivicTransportCard.Data.Repositories
{
    public class TransactionRepository : GenericRepository<TransactionEntity>, ITransactionRepository
    {
        private readonly AppDbContext _appDbContext;
        public TransactionRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public async Task<TransactionEntity> GetRecentTransportTransaction(Guid transportCardId)
        {
            var recentTransaction = await _appDbContext.Transaction
                                        .Where(t => t.TransportCardId == transportCardId
                                                && t.TransactionType == TransactionType.Transport)
                                        .OrderByDescending(t=>t.DateCreated)
                                        .FirstOrDefaultAsync();
            if (recentTransaction == null)
            {
                return null;
            }
            return recentTransaction;
        }
    }
}

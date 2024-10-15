using CivicTransportCard.Core.Entities;
using CivicTransportCard.Data.Repositories.Interface;

namespace CivicTransportCard.Data.Repositories
{
    public class TransactionRepository : GenericRepository<TransactionEntity>, ITransactionRepository
    {
        private readonly AppDbContext _appDbContext;
        public TransactionRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
    }
}

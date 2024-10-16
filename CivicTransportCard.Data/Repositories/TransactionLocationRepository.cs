using CivicTransportCard.Core.Entities;
using CivicTransportCard.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CivicTransportCard.Data.Repositories
{
    public class TransactionLocationRepository : GenericRepository<TransactionLocationEntity>, ITransactionLocationRepository
    {
        private readonly AppDbContext _context;
        public TransactionLocationRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<TransactionLocationEntity> GetTransactionLocationByTransactionId(Guid transactionId)
        {
            var transactionLocation = await _context.TransactionLocation
                                            .Where(tl => tl.TransactionId == transactionId
                                                    && tl.ExitPointLocationId == null)
                                            .FirstOrDefaultAsync();
            if (transactionLocation == null)
            {
                return null;
            }
            return transactionLocation;
        }

        public async Task<List<TransactionLocationEntity>> GetTransactionsByCardId(string cardNo)
        {
            var transactionLocations = await _context.TransactionLocation
                                    .Where(t => t.Transaction.TransportCard.CardNo == cardNo
                                    && t.Transaction.DateCreated.Date == DateTime.Now.Date)
                                    .ToListAsync();
            if (transactionLocations == null)
            {
                return null;
            }

            return transactionLocations;
        }
    }
}

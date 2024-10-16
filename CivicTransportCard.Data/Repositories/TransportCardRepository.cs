using CivicTransportCard.Core.Entities;
using CivicTransportCard.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CivicTransportCard.Data.Repositories
{
    public class TransportCardRepository : GenericRepository<TransportCardEntity>, ITransportCardRepository
    {
        private readonly AppDbContext _appDbContext;

        public TransportCardRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public async Task<TransportCardEntity> GetTransportCardByCardNo(string cardNo)
        {
            if (string.IsNullOrWhiteSpace(cardNo))
            {
                throw new ArgumentNullException(nameof(cardNo));
            }

            return await _appDbContext.TransportCard
                                      .FirstOrDefaultAsync(c => c.CardNo == cardNo);
        }
    }
}

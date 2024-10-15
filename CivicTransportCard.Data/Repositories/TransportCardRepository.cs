using CivicTransportCard.Core.Entities;
using CivicTransportCard.Data.Repositories.Interface;

namespace CivicTransportCard.Data.Repositories
{
    public class TransportCardRepository : GenericRepository<TransportCardEntity>, ITransportCardRepository
    {
        private readonly AppDbContext _appDbContext;
        public TransportCardRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
    }
}

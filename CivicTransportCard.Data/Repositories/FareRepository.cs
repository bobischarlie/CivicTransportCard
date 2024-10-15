using CivicTransportCard.Core.Entities;
using CivicTransportCard.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CivicTransportCard.Data.Repositories
{
    public class FareRepository : GenericRepository<FareEntity>, IFareRepository
    {
        private readonly AppDbContext _appDbContext;
        public FareRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
        public async Task<ICollection<FareEntity>> GetAllFaresAsync()
        {
            return await _appDbContext.Fare
                         .Include(f => f.EntryPointLocation)
                         .Include(f => f.ExitPointLocation)
                         .ToListAsync();

        }
    }
}

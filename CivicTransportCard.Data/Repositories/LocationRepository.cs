using CivicTransportCard.Core.Entities;
using CivicTransportCard.Data.Repositories.Interface;

namespace CivicTransportCard.Data.Repositories
{
    public class LocationRepository : GenericRepository<LocationEntity>, ILocationRepository
    {

        private readonly AppDbContext _context;
        public LocationRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

    }
}

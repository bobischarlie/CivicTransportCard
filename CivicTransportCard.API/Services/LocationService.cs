using AutoMapper;
using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Models;
using CivicTransportCard.Data.Repositories.Interface;

namespace CivicTransportCard.API.Services
{
    public class LocationService : ILocationService
    {
        private readonly IMapper _mapper;
        private readonly ILocationRepository _locationRepository;
        public LocationService(IMapper mapper, ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<List<Location>> GetLocationsAsync()
        {
            var locationsEntity = await _locationRepository.GetAllAsync();
            if(locationsEntity == null)
            {
                throw new ArgumentException("No Location Found.");
            }
            var locations = _mapper.Map<List<Location>>(locationsEntity);
            return locations;
        }
    }
}

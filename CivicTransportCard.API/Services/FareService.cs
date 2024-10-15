using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Models;
using CivicTransportCard.Data.Repositories.Interface;
using AutoMapper;

namespace CivicTransportCard.API.Services
{
    public class FareService : IFareService
    {
        private readonly IFareRepository _fareRepository;
        private readonly IMapper _mapper;
        public FareService(IFareRepository fareRepository, IMapper mapper)
        {
            _fareRepository = fareRepository;
            _mapper = mapper;
        }

        public async Task<List<Fare>> GetFaresAsync()
        {
            var fares = await _fareRepository.GetAllFaresAsync();
            var returnFare = _mapper.Map<List<Fare>>(fares);
            return returnFare;
        }
    }
}

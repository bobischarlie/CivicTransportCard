using AutoMapper;
using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Entities;
using CivicTransportCard.Core.Models;

namespace CivicTransportCard.Core.MapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fare, FareEntity>().ReverseMap();
            CreateMap<Location, LocationEntity>().ReverseMap();
            CreateMap<TransactionEntity, Transaction>().ReverseMap();
            CreateMap<TransportCardEntity, TransportCardRequestContract>().ReverseMap();
            CreateMap<TransportCardEntity, TransportCard>().ReverseMap();
        }
    }
}

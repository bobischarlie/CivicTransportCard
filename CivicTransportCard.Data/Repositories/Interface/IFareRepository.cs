using CivicTransportCard.Core.Entities;

namespace CivicTransportCard.Data.Repositories.Interface
{
    public interface IFareRepository : IGenericRepository<FareEntity>
    {
        Task<ICollection<FareEntity>> GetAllFaresAsync();
    }
}

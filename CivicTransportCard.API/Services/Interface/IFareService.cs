using CivicTransportCard.Core.Models;

namespace CivicTransportCard.API.Services.Interface
{
    public interface IFareService
    {
        Task<List<Fare>> GetFaresAsync();
    }
}

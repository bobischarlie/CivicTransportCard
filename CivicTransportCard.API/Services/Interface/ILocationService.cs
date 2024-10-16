using CivicTransportCard.Core.Models;

namespace CivicTransportCard.API.Services.Interface
{
    public interface ILocationService
    {
        Task<List<Location>> GetLocationsAsync();
    }
}

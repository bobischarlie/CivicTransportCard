using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Models;

namespace CivicTransportCard.API.Services.Interface
{
    public interface ITransportCardService
    {
        Task<TransportCard> AddNewTransportCardAsync(TransportCardRequestContract transportCardRequest);

        Task<TransportCard> ReloadCardAsync(ReloadCardRequestContract reloadRequest);
    }
}

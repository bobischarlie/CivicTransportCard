using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Models;

namespace CivicTransportCard.API.Services.Interface
{
    public interface ITransactionService
    {
        Task<Transaction> UpsertTransaction(UpsertTripRequestContract upsertTripData);
    }
}

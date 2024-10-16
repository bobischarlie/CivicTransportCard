using CivicTransportCard.Core.Entities;

namespace CivicTransportCard.Data.Repositories.Interface
{
    public interface ITransportCardRepository : IGenericRepository<TransportCardEntity>
    {
        Task<TransportCardEntity> GetTransportCardByCardNo(string cardNo);
    }
}

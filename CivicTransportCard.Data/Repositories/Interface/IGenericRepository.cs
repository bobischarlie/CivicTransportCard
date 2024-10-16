using CivicTransportCard.Core.Entities;

namespace CivicTransportCard.Data.Repositories.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<ICollection<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task SaveChangesAsync();
    }
}

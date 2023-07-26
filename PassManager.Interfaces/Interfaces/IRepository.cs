using PassManager.Domain.Models;

namespace PassManager.Domain.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> Create();
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<User> GetById(int id);
    }
}

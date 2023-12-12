using PassManager.Domain.Models;

namespace PassManager.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task Create(TEntity entity);
        Task Update(string username, string profilePicture);
        Task<TEntity> Delete(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<User> GetById(int id);
        Task<User> GetUserByName(string name);
        Task<IEnumerable<StoredPassword>> GetPasswordByUserId(int userId);
        Task SaveChanges();
    }
}

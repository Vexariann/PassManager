using PassManager.Domain.Interfaces;
using PassManager.Domain.Models;

namespace PassManager.Data
{
    public class Repository<TEntity> : IRepository<TEntity>
    {
        public Task<TEntity> Create()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

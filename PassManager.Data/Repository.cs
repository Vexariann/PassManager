using Microsoft.EntityFrameworkCore;
using PassManager.Domain.Interfaces;
using PassManager.Domain.Models;

namespace PassManager.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DataContext _dataContext;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Create(TEntity entity)
        {
            await Task.Run(() => Set().Add(entity));
        }

        public Task<TEntity> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Task.Run(() =>
            {
                IEnumerable<TEntity> entities = Set();
                return entities;
            });
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByName(string name)
        {
            User user = _dataContext.Set<User>().FirstOrDefault(e => e.Username.Equals(name));
            return user;
        }

        public async Task Update(string username, string profilePicture)
        {
            _dataContext.Set<User>().Where(u => u.Username == username).ExecuteUpdate(b => b.SetProperty(u => u.ProfilePicture, profilePicture));
            return;
        }

        public Task SaveChanges()
        {
            return _dataContext.SaveChangesAsync();
        }

        private DbSet<TEntity> Set()
        {
            return _dataContext.Set<TEntity>();
        }

        public async Task<IEnumerable<StoredPassword>> GetPasswordByUserId(int userId)
        {
            //StoredPassword passwords = _dataContext.Set<StoredPassword>().ToArray(e => e)     .FirstOrDefault(e => e.Username.Equals(name));
            //StoredPassword passwords = _dataContext.StoredPassword.Where(e => e.UserID == userId).ToList();
            List<StoredPassword> result = await _dataContext.StoredPassword.Where(x => x.UserID == userId).ToListAsync();
            return result;
        }
    }
}

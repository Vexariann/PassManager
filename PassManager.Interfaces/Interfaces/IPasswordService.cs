using PassManager.Domain.Models;

namespace PassManager.Domain.Interfaces
{
    public interface IPasswordService
    {
        Task<StoredPassword> GetAll();
        Task<bool> Create(StoredPassword password);
        Task<bool> Update(string name, string thumbnail);
        Task<StoredPassword> Delete();
        Task<StoredPassword> GetById(int id);
        Task<IEnumerable<StoredPassword>> GetPasswordByuserId(int id);
        Task<StoredPassword> GetPasswordByName(string name);
    }
}

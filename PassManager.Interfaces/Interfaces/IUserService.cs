using PassManager.Domain.Models;

namespace PassManager.Domain.Interfaces
{
    public interface IUserService
    {
        Task<User> Create();
        Task<User> Update();
        Task<User> Delete();
        Task<User> GetById(int id);
        Task<User> Login(string username, string password);
    }
}

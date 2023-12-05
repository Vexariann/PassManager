using PassManager.Domain.Models;

namespace PassManager.Domain.Interfaces
{
    public interface IUserService
    {
        Task<bool> Create(User user);
        Task<bool> Update(string username, string profilePicture);
        Task<User> Delete();
        Task<User> GetById(int id);
        Task<User> GetUserByName(string name);
        Task<User> Login(string username, string password);
    }
}

using PassManager.Domain.Interfaces;
using PassManager.Domain.Models;

namespace PassManager.Business
{
    public class UserService : IUserService
    {
        // Todo:
        // Save passwords to database. This can be done using the StoredPassword model
        // Fetch passwords from database. Same using the StoredPassword thing
        // Both of these could potentially be done with a repository on the data layer

        // same deal with profiles.
        // I need to able to create a profile as well as fetch profiles from the database
        // the ID from the profile will be associated with the passwords stored.

        // look into hashing

        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Create(User user)
        {
            IEnumerable<User> users = await _userRepository.GetAll();

            if (users.Any(u => u.Username == user.Username))
            {
                return false;
            }

            await _userRepository.Create(user);
            await _userRepository.SaveChanges();
            return true;
        }

        public Task<User> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByName(string name)
        {
            User user = await _userRepository.GetUserByName(name);
            return user;
        }

        public Task<User> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(string username, string profilePicture)
        {
            IEnumerable<User> users = await _userRepository.GetAll();
            if (users.Any(u => u.Username == username))
            {
                await _userRepository.Update(username, profilePicture);
                return true;
            }
            return false;
        }
    }
}

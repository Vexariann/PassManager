using PassManager.Domain.Interfaces;
using PassManager.Domain.Models;

namespace PassManager.Business
{
    internal class UserService : IUserService
    {
        // Todo:
        // Save passwords to database. This can be done using the StoredPassword model
        // Fetch passwords from database. Same using the StoredPassword thing
        // Both of these could potentially be done with a repository on the data layer

        // same deal with profiles.
        // I need to able to create a profile as well as fetch profiles from the database
        // the ID from the profile will be associated with the passwords stored.

        // look into hashing
        public async Task<User> Create()
        {
            throw new NotImplementedException();
        }

        public Task<User> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update()
        {
            throw new NotImplementedException();
        }
    }
}

using PassManager.Domain.Interfaces;
using PassManager.Domain.Models;

namespace PassManager.Business
{
    public class PasswordService : IPasswordService
    {

        // Todo:
        // Save passwords to database. This can be done using the StoredPassword model
        // Fetch passwords from database. Same using the StoredPassword thing
        // Both of these could potentially be done with a repository on the data layer

        // same deal with profiles.
        // I need to able to create a profile as well as fetch profiles from the database
        // the ID from the profile will be associated with the passwords stored.

        // look into hashing

        private readonly IRepository<StoredPassword> _passwordRepository;

        public PasswordService(IRepository<StoredPassword> passwordRepository)
        {
            _passwordRepository = passwordRepository;
        }

        public Task<StoredPassword> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(StoredPassword password)
        {
            throw new NotImplementedException();
        }

        public Task<User> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<StoredPassword> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StoredPassword> GetPasswordByName(string name)
        {
            //name = "Vexarian";
            //return _passwordRepository.GetUserByName(name);
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StoredPassword>> GetPasswordByuserId(int id)
        {
            var passwords = _passwordRepository.GetPasswordByUserId(id);
            return passwords;
        }

        public Task<bool> Update(string name, string thumbnail)
        {
            throw new NotImplementedException();
        }

        Task<StoredPassword> IPasswordService.Delete()
        {
            throw new NotImplementedException();
        }
    }
}
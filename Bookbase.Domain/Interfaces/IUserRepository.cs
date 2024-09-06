using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAll();
        public Task<User?> GetOne(int userId);
        public Task<User> Create(User user);
        
        public Task<User> Update(int id, User user);
    }
}

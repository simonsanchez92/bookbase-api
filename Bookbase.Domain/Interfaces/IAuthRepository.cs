using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IAuthRepository
    {
        public Task<User> Login(string email);

    }
}

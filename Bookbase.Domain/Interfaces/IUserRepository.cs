using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public Task<User?> GetOne(Expression<Func<User, bool>> predicate);
    }
}

using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        //public Task<IEnumerable<User>> GetAll();

        public Task<User?> GetOne(Expression<Func<User, bool>> predicate);

    }
}

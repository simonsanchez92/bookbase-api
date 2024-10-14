using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bookbase.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<User?> GetOne(Expression<Func<User, bool>> predicate)
        {
            return await _context.Users.FirstOrDefaultAsync(predicate);

        }

    }
}

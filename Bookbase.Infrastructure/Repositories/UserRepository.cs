using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<User?> GetOne(int userId)
        //{
        //    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId && !u.Deleted);

        //    //if(user == null)
        //    //{
        //    //    //TODO: retrieve err 
        //    //    throw new KeyNotFoundException($"User with id {userId} not found");
        //    //}

        //    return user;
        //}


        public async Task<User?> GetOne(Dictionary<string, object> filters)
        {
            IQueryable<User> query = _context.Users.Where(u => !u.Deleted);

            foreach (var filter in filters)
            {
                switch (filter.Key.ToLower())
                {
                    case "id":
                        query = query.Where(u => u.Id == (int)filter.Value);
                        break;
                    case "username":
                        query = query.Where(u => u.Username == (string)filter.Value);
                        break;
                    case "email":
                        query = query.Where(u => u.Email == (string)filter.Value);
                        break;
                    default:
                        throw new ArgumentException($"Invalid filter key: {filter.Key}");
                }
            }

            var user = await query.FirstOrDefaultAsync();

            return user;
        }


        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.Where(u => !u.Deleted).ToListAsync();
        }

        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Update(int userId, User user)
        {
            var filtersById = new Dictionary<string, object> { { "id", userId } };

            var currentUser = await GetOne(filtersById);

            if (currentUser != null) { 
                currentUser.Username = user.Username;
                currentUser.Password = user.Password;
                currentUser.RoleId = user.RoleId;

                _context.Users.Update(currentUser);
                await _context.SaveChangesAsync();
                return currentUser;
            }

            //Return err if not found
            return null;
        }

        public async Task<bool> Delete(int userId)
        {
            var filtersById = new Dictionary<string, object> { { "id", userId } };

            var user = await GetOne(filtersById);

            if (user == null) return false;

            user.Deleted = true;

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

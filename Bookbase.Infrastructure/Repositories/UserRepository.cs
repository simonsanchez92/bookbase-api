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

        public async Task<User?> GetOne(int userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if(user == null)
            {
                //TODO: retrieve err 
            }

            return user;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return _context.Users.ToList();
        }

        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Update(int id, User user)
        {
            var currentUser = await GetOne(id);

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
    }
}

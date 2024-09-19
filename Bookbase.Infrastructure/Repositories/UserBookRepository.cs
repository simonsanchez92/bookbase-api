using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;

namespace Bookbase.Infrastructure.Repositories
{
    public class UserBookRepository : IUserBookRepository
    {
        private readonly ApplicationDbContext _context;


        public UserBookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserBook> Add(int bookId, int userId)
        {
            var userBook = new UserBook
            {
                UserId = userId,
                BookId = bookId,
                Status = "Want to read"
            };

            _context.UserBooks.Add(userBook);

            await _context.SaveChangesAsync();

            return userBook;

        }
    }
}

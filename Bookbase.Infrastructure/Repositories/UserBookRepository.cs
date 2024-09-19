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

        public async Task<UserBook> Add(int userId, int bookId)
        {
            var userBook = new UserBook
            {
                UserId = userId,
                BookId = bookId,
                Status = "Want to read"
            };

            _context.UserBooks.Add(userBook);
            await _context.SaveChangesAsync();

            await _context.Entry(userBook).Reference(ub => ub.User).LoadAsync();
            await _context.Entry(userBook).Reference(ub => ub.Book).LoadAsync();

            return userBook;

        }
    }
}

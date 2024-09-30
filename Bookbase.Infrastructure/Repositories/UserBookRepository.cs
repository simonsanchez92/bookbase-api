using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class UserBookRepository : IUserBookRepository
    {
        private readonly ApplicationDbContext _context;


        public UserBookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserBook?> Add(int userId, int bookId)
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

            //return userBook;

            return await GetOne(userId, bookId);

        }

        public async Task<UserBook?> GetOne(int userId, int bookId)
        {
            // Retrieve object including related entities

            var userBook = await _context.UserBooks
                .Include(ub => ub.Book)
                    .ThenInclude(b => b.BookGenres)
                    .ThenInclude(bg => bg.Genre)
                    .FirstOrDefaultAsync(ub => ub.UserId == userId && ub.BookId == bookId);

            return userBook;
        }

        public async Task<bool> Delete(UserBook userBook)
        {
            _context.UserBooks.Remove(userBook);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<UserBook>> GetAll(int userId)
        {
            var userBooks = await _context.UserBooks.Where(ub => ub.UserId == userId).ToListAsync();

            return userBooks;
        }

        public async Task<IEnumerable<UserBook>> GetList(int userId)
        {
            var userBooks = await _context.UserBooks
                .Where(ub => ub.UserId == userId)
                .Include(ub => ub.Book)
                .ThenInclude(b => b.BookGenres)
                .ThenInclude(bg => bg.Genre)
                .ToListAsync();

            return userBooks;
        }

        public async Task<UserBook?> Shelve(UserBook userBook)
        {
            _context.UserBooks.Add(userBook);
            await _context.SaveChangesAsync();

            return await GetOne(userBook.UserId, userBook.BookId);
        }

        public async Task<UserBook?> Update(UserBook userBook)
        {
            _context.UserBooks.Update(userBook);
            await _context.SaveChangesAsync();

            return userBook;
        }
    }
}

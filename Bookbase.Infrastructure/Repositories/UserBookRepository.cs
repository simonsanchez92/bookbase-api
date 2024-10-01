using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Bookbase.Infrastructure.Utils;
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

        //public async Task<IEnumerable<UserBook>> GetList(int userId)
        //{
        //    var userBooks = await _context.UserBooks
        //        .Where(ub => ub.UserId == userId)
        //        .Include(ub => ub.Book)
        //        .ThenInclude(b => b.BookGenres)
        //        .ThenInclude(bg => bg.Genre)
        //        .ToListAsync();

        //    return userBooks;
        //}

        public async Task<GenericListResponse<UserBook>> GetList(int userId, int page, int pageSize)
        {
            // Params
            // TODO: cambiar
            IQueryable<UserBook> query = _context.UserBooks
                .Where(b => b.UserId == userId)
                .Include(ub => ub.Book) //Include the related book
                .ThenInclude(b => b.BookGenres) //Include BookGenres for each book
                .ThenInclude(bg => bg.Genre); //Include genre for each BookGenre



            // TODO: aplicaría filtros

            //Pagination
            int total = await query.CountAsync();

            //
            int currentPage = page < 1 ? PaginationConstants.DefaultPage : page;
            int currentLength = pageSize < 1 ? PaginationConstants.DefaultPageSize : pageSize;

            //
            int skip = (currentPage - 1) * currentLength;

            query = query.Skip(skip).Take(currentLength);
            var data = await query.ToListAsync();

            return new GenericListResponse<UserBook>
            {
                Total = total,
                Page = page,
                Length = pageSize,
                Data = data
            };
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

        public async Task<bool> Delete(UserBook userBook)
        {
            _context.UserBooks.Remove(userBook);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}

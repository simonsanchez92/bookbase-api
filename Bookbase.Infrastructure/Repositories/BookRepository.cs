using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Bookbase.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookResponse?> GetOne(int? userId, int bookId)
        {
            var book = await _context.Books
                            .Include(b => b.BookGenres)
                                .ThenInclude(bg => bg.Genre)
                            .Include(b => b.UserBooks)
                                .ThenInclude(ub => ub.ReadingStatus)
                            .Select(b => new BookResponse
                            {
                                Book = b,
                                UserBook = b.UserBooks.FirstOrDefault(ub => ub.UserId == userId)
                            })
                            .FirstOrDefaultAsync(b => b.Book.Id == bookId && !b.Book.Deleted);

            return book;
        }
        public async Task<GenericListResponse<BookResponse>> GetList(int? userId, int page, int pageSize)
        {
            // Params
            // TODO: cambiar
            var query = _context.Books
                .Include(b => b.BookGenres)
                    .ThenInclude(bg => bg.Genre)
                .Include(b => b.UserBooks)
                    .ThenInclude(ub => ub.ReadingStatus)
                .Select(b => new BookResponse
                {
                    Book = b,
                    UserBook = b.UserBooks.FirstOrDefault(ub => ub.UserId == userId)
                })
                .Where(b => !b.Book.Deleted);

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

            return new GenericListResponse<BookResponse>
            {
                Total = total,
                Page = page,
                Length = pageSize,
                Data = data
            };

        }

        public async Task<GenericListResponse<BookResponse>> GetUserShelf(int userId, int page, int pageSize)
        {
            // Params
            // TODO: cambiar
            var query = _context.Books
                .Include(b => b.BookGenres)
                    .ThenInclude(bg => bg.Genre)
                .Include(b => b.UserBooks)
                    .ThenInclude(ub => ub.ReadingStatus)
                .Where(b => b.UserBooks.Any(ub => ub.UserId == userId))
                .Select(b => new BookResponse
                {
                    Book = b,
                    UserBook = b.UserBooks.FirstOrDefault(ub => ub.UserId == userId)
                })
                .Where(b => !b.Book.Deleted);

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

            return new GenericListResponse<BookResponse>
            {
                Total = total,
                Page = page,
                Length = pageSize,
                Data = data
            };
        }
        public async Task<Book> Create(Book book, List<int> genreIds)
        {

            // Retrieve the genres that match the genreIds
            var genres = await _context.Genres.Where(g => genreIds.Contains(g.Id)).ToListAsync();

            // Assign the genres to the book entity
            book.BookGenres = genres.Select(g => new BookGenre { GenreId = g.Id, Book = book }).ToList();


            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return book;
        }

        public async Task<Book> Update(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<BookResponse?> Shelve(UserBook userBook)
        {
            _context.UserBooks.Add(userBook);
            await _context.SaveChangesAsync();

            return await GetOne(userBook.UserId, userBook.BookId);
        }

        public async Task<UserBook> UpdateUserBook(UserBook userBook)
        {
            _context.UserBooks.Update(userBook).Property(ub => ub.UpdatedAt).IsModified = true;

            await _context.SaveChangesAsync();

            return await GetOneUserBook(userBook.UserId, userBook.BookId);
        }

        public async Task<UserBook> GetOneUserBook(int userId, int bookId)
        {
            return await _context.UserBooks
                            .Include(ub => ub.ReadingStatus)
                            .FirstAsync(ub => ub.UserId == userId && ub.BookId == bookId);
        }

        public async Task<bool> RemoveFromShelf(UserBook userBook)
        {
            _context.UserBooks.Remove(userBook);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}

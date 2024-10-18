using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Bookbase.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

namespace Bookbase.Infrastructure.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {


        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }


        public async Task<IEnumerable<BookResponse>> GetAllWithIncludes(int? userId)
        {
            var books = await GetAll(query =>

                query.Include(b => b.BookGenres)
                      .ThenInclude(bg => bg.Genre)
                      .Include(b => b.UserBooks)
                      .ThenInclude(ub => ub.ReadingStatus)
                      );

            return books.Select(b => new BookResponse
            {
                Book = b,
                UserBook = b.UserBooks.FirstOrDefault(ub => ub.UserId == userId)

            }).ToList();
        }

        public async Task<BookResponse?> GetOne(int? userId, int bookId)
        {
            var book = await GetOne(bookId,
                query => query
             .Include(b => b.BookGenres)
            .ThenInclude(bg => bg.Genre)
            .Include(b => b.UserBooks)
            .ThenInclude(ub => ub.ReadingStatus)
            );


            if (book != null)
            {
                var userBook = book.UserBooks.FirstOrDefault(ub => ub.UserId == userId);

                return new BookResponse
                {
                    Book = book,
                    UserBook = userBook
                };
            }
            return null;

        }
        public async Task<Book> Create(Book book, List<int>? genreIds)
        {

            // Retrieve the genres that match the genreIds
            var genres = await _context.Genres.Where(g => genreIds.Contains(g.Id)).ToListAsync();

            //// Assign the genres to the book entity
            book.BookGenres = genres.Select(g => new BookGenre { GenreId = g.Id, Book = book }).ToList();

            //Calling base repository 
            await Create(book);

            return book;
        }

        public async Task<GenericListResponse<BookResponse>> GetList(int? userId, int page, int pageSize, string? queryStr = null)
        {
            // Params
            IQueryable<BookResponse> query = _context.Books
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


            if (!string.IsNullOrEmpty(queryStr))
            {
                string decodedQuery = Encoding.UTF8.GetString(Convert.FromBase64String(queryStr));
                QueryObject? queryObject = JsonSerializer.Deserialize<QueryObject>(decodedQuery);

                if (queryObject != null)
                {
                    //Filters
                    query = QueryHelpers.ApplyFilters(query, queryObject);
                    //Sorting
                    query = QueryHelpers.ApplySorting(query, queryObject.Sorts);
                }

            }

            //Pagination
            query = QueryHelpers.ApplyPagination(query, page, pageSize, out var total);

            var data = await query.ToListAsync();

            return new GenericListResponse<BookResponse>
            {
                Total = total,
                Page = page,
                Length = pageSize,
                Data = data
            };

        }

    }
}

using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Bookbase.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
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

                if (!string.IsNullOrEmpty(queryObject!.Search))
                {
                    var containsValue = queryObject.Search.ToLower();

                    query = query.Where(b => b.Book.Title.ToLower().Contains(containsValue) ||
                                    b.Book.Author.ToLower().Contains(containsValue) ||
                         (b.Book.Description != null && b.Book.Description.ToLower().Contains(containsValue)));
                }

                foreach (var filter in queryObject.Filters)
                {
                    var parameter = Expression.Parameter(typeof(BookResponse), "b");
                    var property = Expression.Property(Expression.Property(parameter, "Book"), filter.propertyName);

                    Expression? expression;

                    var propertyType = property.Type;

                    var value = (propertyType == typeof(string)) ? filter.value : Convert.ChangeType(filter.value, propertyType);

                    switch (filter.type)
                    {
                        case FilterTypes.Equals:
                            expression = Expression.Equal(property, Expression.Constant(value));
                            break;
                        case FilterTypes.NotEquals:
                            expression = Expression.NotEqual(property, Expression.Constant(value));
                            break;
                        case FilterTypes.GreaterThan:
                            expression = Expression.GreaterThan(property, Expression.Constant(value));
                            break;
                        case FilterTypes.LowerThan:
                            expression = Expression.LessThan(property, Expression.Constant(value));
                            break;
                        case FilterTypes.GreaterThanEquals:
                            expression = Expression.GreaterThanOrEqual(property, Expression.Constant(value));
                            break;
                        case FilterTypes.LowerThanEquals:
                            expression = Expression.LessThanOrEqual(property, Expression.Constant(value));
                            break;
                        case FilterTypes.Like:
                            var likeValue = $"%{value}%";
                            var methodInfo = typeof(string).GetMethod("Contains", new[] { typeof(string) })!;
                            expression = Expression.Call(property, methodInfo, Expression.Constant(likeValue));
                            break;

                        case FilterTypes.Between:

                            var fromValue = (propertyType == typeof(string)) ? filter.from : Convert.ChangeType(filter.from, propertyType);
                            var toValue = (propertyType == typeof(string)) ? filter.to : Convert.ChangeType(filter.to, propertyType);


                            var greaterThanOrEqual = Expression.GreaterThanOrEqual(property, Expression.Constant(fromValue));
                            var lessThanOrEqual = Expression.LessThanOrEqual(property, Expression.Constant(toValue));

                            expression = Expression.AndAlso(greaterThanOrEqual, lessThanOrEqual);
                            break;

                        case FilterTypes.Contains:

                            var methodInfoContains = typeof(string).GetMethod("Contains", new[] { typeof(string) })!;

                            expression = Expression.Call(property, methodInfoContains, Expression.Constant(value?.ToString() ?? ""));
                            break;
                        default:
                            throw new InvalidOperationException($"Unsopported filter type: {filter.type}");
                    }


                    var expressionFn = Expression.Lambda<Func<BookResponse, bool>>(expression, parameter);

                    query = query.Where(expressionFn);

                }

                //Sorting
                foreach (var item in queryObject.Sorts)
                {
                    var parameter = Expression.Parameter(typeof(BookResponse), "b");
                    var property = Expression.Property(Expression.Property(parameter, "Book"), item.propertyName);

                    var expression = Expression.Lambda<Func<BookResponse, object>>(Expression.Convert(property, typeof(object)), parameter);


                    if (item.descending)
                    {
                        query = query.OrderByDescending(expression);
                    }
                    else
                    {
                        query = query.OrderBy(expression);
                    }
                }

            }
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

    }
}

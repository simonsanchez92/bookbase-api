using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bookbase.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
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

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books
                .Include(b => b.BookGenres)
                    .ThenInclude(bg => bg.Genre)
                .Where(b => !b.Deleted).ToListAsync();
        }

        public Task<IEnumerable<Book?>> GetMany()
        {
            throw new NotImplementedException();
        }

        public async Task<Book?> GetOne(int bookId)
        {
            var book = await _context.Books.Include(b => b.BookGenres)
                                .ThenInclude(bg => bg.Genre)
                                .FirstOrDefaultAsync(b => b.Id == bookId);

            if (book == null)
            {
                //    //TODO: retrieve err 
                //    throw new KeyNotFoundException($"User with id {userId} not found");
            }
            return book;
        }

        public Task<Book> GetOne(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }


        public async Task<Book> Update(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }


        public async Task<IEnumerable<Book>> Search(string? title, string? author)
        {

            var query = _context.Books.AsQueryable();

            if (!String.IsNullOrEmpty(title))
            {
                query = query.Where(b => b.Title.Contains(title));
            }

            if (!String.IsNullOrEmpty(author))
            {
                query = query.Where(b => b.Author.Contains(author));
            }

            return await query.ToListAsync();
        }

    }
}

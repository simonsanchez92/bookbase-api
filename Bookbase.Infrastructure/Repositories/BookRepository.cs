﻿using Bookbase.Domain.Interfaces;
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
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            foreach (var id in genreIds)
            {
                var bookGenre = new BookGenre
                {
                    BookId = book.Id,
                    GenreId = id
                };

                _context.BookGenres.Add(bookGenre);
            }

            await _context.SaveChangesAsync();

            return book;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.Where(b => !b.Deleted).ToListAsync();
        }

        public Task<IEnumerable<Book?>> GetMany()
        {
            throw new NotImplementedException();
        }

        public async Task<Book?> GetOne(int bookId)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == bookId);
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
    }
}
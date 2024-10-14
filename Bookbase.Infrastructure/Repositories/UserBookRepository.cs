﻿using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class UserBookRepository : BaseRepository<UserBook>, IUserBookRepository
    {
        private readonly IBookRepository _bookRepository;

        public UserBookRepository(ApplicationDbContext context, IBookRepository bookRepository) : base(context)
        {
            _bookRepository = bookRepository;
        }

        public async Task<UserBook?> GetOneUserBook(int userId, int bookId)
        {
            //Adding ReadingStatus navigation property
            IncludeDelegate<UserBook> include = query => query.Include(ub => ub.ReadingStatus);

            IQueryable<UserBook> query = _dbSet.Where(ub => ub.UserId == userId && ub.BookId == bookId);

            if (include != null)
            {
                query = include(query);
            }


            return await query.FirstOrDefaultAsync();

            //return await _context.UserBooks
            //                .Include(ub => ub.ReadingStatus)
            //                .FirstAsync(ub => ub.UserId == userId && ub.BookId == bookId);
        }
        public async Task<BookResponse?> Shelve(UserBook userBook)
        {
            //_context.UserBooks.Add(userBook);
            await Create(userBook);
            await _context.SaveChangesAsync();

            return await _bookRepository.GetOne(userBook.UserId, userBook.BookId);
        }


        public async Task<UserBook> UpdateUserBook(UserBook userBook)
        {
            // Update the UserBook record using the BaseRepository's Update method
            await Update(userBook);

            // Manually mark the UpdatedAt property as modified if it's a custom field not automatically tracked
            _context.Entry(userBook).Property(ub => ub.UpdatedAt).IsModified = true;

            await _context.SaveChangesAsync();

            return await GetOneUserBook(userBook.UserId, userBook.BookId);
        }

        public async Task<bool> RemoveFromShelf(UserBook userBook)
        {
            _context.UserBooks.Remove(userBook);
            await _context.SaveChangesAsync();

            return true;
        }

        public Task<GenericListResponse<BookResponse>> GetUserShelf(int userId, int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
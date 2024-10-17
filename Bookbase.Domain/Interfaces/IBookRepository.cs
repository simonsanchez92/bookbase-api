﻿using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {

        public Task<IEnumerable<BookResponse>> GetAllWithIncludes(int? userId);
        public Task<GenericListResponse<BookResponse>> GetList(int? userId, int page, int pageSize, string? query);
        //public Task<GenericListResponse<BookResponse>> GetUserShelf(int userId, int page, int pageSize);
        public Task<BookResponse?> GetOne(int? userId, int bookId);
        //public Task<UserBook> GetOneUserBook(int userId, int bookId);
        public Task<Book> Create(Book book, List<int>? genreIds);
        //public Task<UserBook> UpdateUserBook(UserBook userBook);

        //public Task<bool> RemoveFromShelf(UserBook userBook);


    }
}

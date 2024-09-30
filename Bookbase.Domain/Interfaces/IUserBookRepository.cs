﻿using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserBookRepository
    {
        public Task<UserBook?> Add(int userId, int bookId);
        public Task<UserBook?> Shelve(UserBook userBook);
        public Task<UserBook?> GetOne(int userId, int bookId);

        public Task<IEnumerable<UserBook>> GetAll(int userId);
        //public Task<IEnumerable<Book?>> GetMany();
        //public Task<Book> GetOne(Expression<Func<Book, bool>> predicate);

        public Task<IEnumerable<UserBook>> GetList(int userId);

        public Task<bool> Delete(UserBook userBook);

        public Task<UserBook?> Update(UserBook userBook);


        //public Task<UserBook?> Upsert(int userId, int bookId, Action<UserBook> updateFields);


    }
}

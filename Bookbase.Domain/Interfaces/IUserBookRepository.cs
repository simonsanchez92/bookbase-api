using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserBookRepository
    {
        public Task<UserBook> Add(int userId, int bookId);
        public Task<UserBook?> GetOne(int userId, int bookId);

        public Task<UserBook> Update(UserBook userBook);

        //public Task<IEnumerable<UserBook>> GetAll();
        //public Task<IEnumerable<Book?>> GetMany();
        //public Task<Book> GetOne(Expression<Func<Book, bool>> predicate);

        public Task<bool> Delete(UserBook userBook);

    }
}

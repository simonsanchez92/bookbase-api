using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserBookRepository
    {
        public Task<UserBook> Add(int userId, int bookId);
        //public Task<IEnumerable<UserBook>> GetAll();
        //public Task<IEnumerable<Book?>> GetMany();
        //public Task<Book?> GetOne(int bookId);
        //public Task<Book> GetOne(Expression<Func<Book, bool>> predicate);
        //public Task<Book> Update(Book book);
    }
}

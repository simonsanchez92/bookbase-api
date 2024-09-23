using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Domain.Interfaces
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAll();
        public Task<IEnumerable<Book?>> GetMany();
        public Task<Book?> GetOne(int bookId);
        public Task<Book> GetOne(Expression<Func<Book, bool>> predicate);
        public Task<Book> Create(Book book, List<int> genreIds);
        public Task<Book> Update(Book book);

        public Task<IEnumerable<Book>> Search(string? title, string? author);

    }
}

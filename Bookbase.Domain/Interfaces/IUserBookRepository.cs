using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserBookRepository : IBaseRepository<UserBook>
    {
        public Task<BookResponse?> Shelve(UserBook userBook);

        public Task<bool> RemoveFromShelf(UserBook userBook);

        public Task<UserBook> UpdateUserBook(UserBook userBook);

        public Task<UserBook?> GetOneUserBook(int userId, int bookId);

        public Task<GenericListResponse<BookResponse>> GetUserShelf(int userId, int page, int pageSize);
    }
}

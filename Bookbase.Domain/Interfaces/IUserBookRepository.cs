using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserBookRepository
    {
        public Task<UserBook?> Shelve(UserBook userBook);
        public Task<UserBook?> GetOne(int userId, int bookId);
        //public Task<IEnumerable<UserBook>> GetList(int userId);
        public Task<GenericListResponse<UserBook>> GetList(int userId, int page, int pageSize);
        public Task<bool> Delete(UserBook userBook);
        public Task<UserBook?> Update(UserBook userBook);

    }
}

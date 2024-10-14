using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface ILikeRepository : IBaseRepository<Like>
    {
        public Task<bool> Delete(Like like);
        public Task<Like?> GetOne(int reviewId, int userId);
        public Task<GenericListResponse<Like>> GetList(int reviewId, int page, int pageSize);




    }
}

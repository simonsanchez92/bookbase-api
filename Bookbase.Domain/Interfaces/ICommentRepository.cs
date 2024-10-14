using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        public Task<Comment> CreateComment(Comment book);
        public Task<Comment?> GetOne(int reviewId, int commentId);

        public Task<GenericListResponse<Comment>> GetList(int reviewId, int page, int pageSize);

        public Task<bool> Delete(Comment comment);
    }
}

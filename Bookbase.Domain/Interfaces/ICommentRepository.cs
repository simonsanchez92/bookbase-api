using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface ICommentRepository
    {
        public Task<Comment> Create(Comment book);
        public Task<Comment?> GetOne(int reviewId, int commentId);

        public Task<GenericListResponse<Comment>> GetList(int reviewId, int page, int pageSize);

        public Task<bool> Delete(Comment comment);
    }
}

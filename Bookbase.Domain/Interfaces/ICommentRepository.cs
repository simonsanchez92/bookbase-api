using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface ICommentRepository
    {
        public Task<Comment?> GetOne(int commentId);
        public Task<Comment> Create(Comment book);
    }
}

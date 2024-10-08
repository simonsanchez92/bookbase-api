using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface ICommentService
    {
        public Task<CommentResponseDto> Create(int reviewId, int userId, CreateCommentDto commentDto);

        public Task<CommentResponseDto?> GetOne(int commentId);
    }
}

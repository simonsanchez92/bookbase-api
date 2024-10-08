using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface ICommentService
    {
        public Task<CommentResponseDto> Create(CreateCommentDto commentDto);

        public Task<CommentResponseDto?> GetOne(int commentId);
    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;

namespace Bookbase.Application.Interfaces
{
    public interface ICommentService
    {
        public Task<CommentResponseDto> Create(int reviewId, int userId, CreateCommentDto commentDto);
        public Task<CommentResponseDto?> GetOne(int reviewId, int commentId);
        public Task<GenericListResponse<CommentResponseDto>> GetList(int reviewId, int page, int pageSize);
    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Interfaces
{
    public interface ICommentService : IBaseService<Comment, CommentDto, CommentResponseDto, CreateCommentDto, UpdateCommentDto>
    {
        public Task<CommentResponseDto> Create(int reviewId, int userId, CreateCommentDto commentDto);
        public Task<CommentResponseDto?> GetOne(int reviewId, int commentId);
        public Task<GenericListResponse<CommentResponseDto>> GetList(int reviewId, int page, int pageSize);

        public Task<GenericResponseDto> Delete(int reviewId, int commentId, int userId);

    }
}

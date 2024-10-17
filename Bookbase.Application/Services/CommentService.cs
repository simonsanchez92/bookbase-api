using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class CommentService : BaseService<Comment, CommentDto, CommentResponseDto, CreateCommentDto, UpdateCommentDto>, ICommentService
    {
        private new readonly ICommentRepository _repository;
        private readonly IReviewService _reviewService;

        public CommentService(ICommentRepository repository, IReviewRepository reviewRepository, IReviewService reviewService, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _reviewService = reviewService;
        }

        public async Task<CommentResponseDto> Create(int reviewId, int userId, CreateCommentDto commentDto)
        {

            //Check whether review exists
            var review = await _reviewService.GetOne(reviewId);

            if (review == null)
            {
                throw new NotFoundException($"Review with id {reviewId} does not exist")
                {
                    ErrorCode = "003"
                };
            }

            Comment newComment = new Comment
            {
                ReviewId = reviewId,
                UserId = userId,
                Content = commentDto.Content
            };

            var createdComment = await _repository.CreateComment(newComment);

            return _mapper.Map<CommentResponseDto>(createdComment);
        }

        public async Task<CommentResponseDto?> GetOne(int reviewId, int commentId)
        {
            var comment = await _repository.GetOne(reviewId, commentId);


            return _mapper.Map<CommentResponseDto>(comment);
        }


        public async Task<GenericListResponse<CommentResponseDto>> GetList(int reviewId, int page, int pageSize)
        {
            var comments = await _repository.GetList(reviewId, page, pageSize);


            return _mapper.Map<GenericListResponse<CommentResponseDto>>(comments);
        }

        public async Task<GenericResponseDto> Delete(int reviewId, int commentId, int userId)
        {
            var comment = await _repository.GetOne(reviewId, commentId);

            if (comment == null)
            {
                throw new NotFoundException("Comment does not exist")
                {
                    ErrorCode = "004"
                };
            }
            if (comment.UserId != userId)
            {
                throw new UnauthorizedException("Cannot delete another user's comment")
                {
                    ErrorCode = "008"
                };
            }

            //Delete comment
            return await base.Delete(comment.Id);
        }
    }
}

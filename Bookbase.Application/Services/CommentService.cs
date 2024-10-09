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
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IReviewRepository reviewRepository, IReviewService reviewService, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _reviewService = reviewService;
            _mapper = mapper;
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

            var createdComment = await _commentRepository.Create(newComment);

            return _mapper.Map<CommentResponseDto>(createdComment);
        }

        public async Task<CommentResponseDto?> GetOne(int reviewId, int commentId)
        {
            var comment = await _commentRepository.GetOne(reviewId, commentId);


            return _mapper.Map<CommentResponseDto>(comment);
        }


        public async Task<GenericListResponse<CommentResponseDto>> GetList(int reviewId, int page, int pageSize)
        {
            var comments = await _commentRepository.GetList(reviewId, page, pageSize);


            return _mapper.Map<GenericListResponse<CommentResponseDto>>(comments);
        }

    }
}

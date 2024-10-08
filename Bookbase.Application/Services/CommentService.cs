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
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IReviewRepository reviewRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<CommentResponseDto> Create(int reviewId, int userId, CreateCommentDto commentDto)
        {

            //Check whether review exists
            var review = await _reviewRepository.GetOne(reviewId);

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

        public async Task<CommentResponseDto?> GetOne(int commentId)
        {
            var comment = await _commentRepository.GetOne(commentId);


            return _mapper.Map<CommentResponseDto>(comment);
        }


        public async Task<GenericListResponse<CommentResponseDto>> GetList(int reviewId, int page, int pageSize)
        {
            var comments = await _commentRepository.GetList(reviewId, page, pageSize);




            return _mapper.Map<GenericListResponse<CommentResponseDto>>(comments);
        }

    }
}

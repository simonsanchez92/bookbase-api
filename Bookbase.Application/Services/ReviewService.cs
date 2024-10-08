using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<CreateReviewResponseDto> Create(CreateReviewDto reviewDto, int userId)
        {
            var existingReview = await _reviewRepository.GetOne(r => r.UserId == userId && r.BookId == reviewDto.BookId);

            if (existingReview != null)
            {

                throw new BadRequestException($"User already has reviewed this book")
                {
                    ErrorCode = "011"
                };
            }

            Review newReview = new Review
            {
                Content = reviewDto.Content,
                BookId = reviewDto.BookId,
                UserId = userId
            };

            var review = await _reviewRepository.Create(newReview);

            return _mapper.Map<CreateReviewResponseDto>(review);
        }

        public async Task<IEnumerable<ReviewResponseDto>> GetBookReviews(int bookId)
        {
            var bookReviews = await _reviewRepository.GetBookReviews(bookId);


            return _mapper.Map<IEnumerable<ReviewResponseDto>>(bookReviews);
        }

        public async Task<ReviewResponseDto?> GetOne(int reviewId)
        {
            var review = await _reviewRepository.GetOne(reviewId);

            if (review == null)
            {
                throw new NotFoundException($"No review found with id {reviewId}")
                {
                    ErrorCode = "004"
                };
            }

            return _mapper.Map<ReviewResponseDto>(review);
        }

        public async Task<bool> Delete(int userId, int reviewId)
        {
            var review = await _reviewRepository.GetOne(reviewId);

            if (review == null)
            {
                throw new BadRequestException("Review does not exist")
                {
                    ErrorCode = "005"
                };
            }

            if (review.UserId != userId)
            {
                throw new UnauthorizedException("Action not authorized for this user")
                {
                    ErrorCode = "010"
                };
            }

            return await _reviewRepository.Delete(review);
        }

    }
}

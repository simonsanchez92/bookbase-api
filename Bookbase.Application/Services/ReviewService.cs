using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class ReviewService : BaseService<Review, CreateReviewResponseDto, ReviewResponseDto, CreateReviewDto, UpdateReviewDto>, IReviewService
    {
        private new readonly IReviewRepository _repository;


        public ReviewService(IReviewRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        public override async Task<CreateReviewResponseDto> Create(CreateReviewDto body)
        {
            var reviewExists = await _repository.GetOne(r => r.UserId == body.UserId && r.BookId == body.BookId);

            if (reviewExists != null)
            {
                throw new BadRequestException($"User already has reviewed this book")
                {
                    ErrorCode = "011"
                };
            }

            return await base.Create(body);
        }

        public async Task<IEnumerable<ReviewResponseDto>> GetBookReviews(int bookId)
        {
            var bookReviews = await _repository.GetBookReviews(bookId);

            return _mapper.Map<IEnumerable<ReviewResponseDto>>(bookReviews);
        }

        public override async Task<ReviewResponseDto?> GetOne(int reviewId)
        {
            var review = await _repository.GetOne(reviewId);

            if (review == null)
            {
                throw new NotFoundException($"No review found with id {reviewId}")
                {
                    ErrorCode = "004"
                };
            }

            return _mapper.Map<ReviewResponseDto>(review);
        }

        public async Task<CreateReviewResponseDto> Update(int userId, int reviewId, UpdateReviewDto body)
        {
            var review = await _repository.GetOne(reviewId);
            if (review == null)
            {
                throw new NotFoundException($"No review found with id {reviewId}")
                {
                    ErrorCode = "004"
                };
            }

            if (review.User.Id != userId)
            {
                throw new UnauthorizedException($"Action forbidden for this user")
                {
                    ErrorCode = "004"
                };
            }

            return await base.Update(reviewId, body);
        }
        public async Task<GenericResponseDto> Delete(int userId, int reviewId)
        {
            var review = await _repository.GetOne(reviewId);

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
            return await Delete(review.Id);
        }

    }
}

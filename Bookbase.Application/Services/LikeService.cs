using AutoMapper;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;

        public LikeService(ILikeRepository likeRepository, IReviewService reviewService, IMapper mapper)
        {
            _likeRepository = likeRepository;
            _reviewService = reviewService;
            _mapper = mapper;
        }

        public async Task<LikeResponseDto> Create(int reviewId, int userId)
        {

            try
            {
                await _reviewService.GetOne(reviewId);
            }
            catch (Exception)
            {
                throw new BadRequestException($"Review with Id of {reviewId} does not exist")
                {
                    ErrorCode = "013"
                };
            }

            var likeExists = await _likeRepository.GetOne(reviewId, userId);

            if (likeExists != null)
            {
                throw new BadRequestException($"User has already liked this review")
                {
                    ErrorCode = "013"
                };
            }

            Like newLike = new Like()
            {
                UserId = userId,
                ReviewId = reviewId,
            };

            var like = await _likeRepository.Create(newLike);

            return _mapper.Map<LikeResponseDto>(like);
        }

        public async Task<LikeResponseDto?> GetOne(int reviewId, int userId)
        {
            var like = await _likeRepository.GetOne(reviewId, userId);

            if (like == null)
            {
                throw new NotFoundException($"No like found for review {reviewId}")
                {
                    ErrorCode = "004"
                };
            }

            return _mapper.Map<LikeResponseDto>(like);
        }


        public async Task<bool> Delete(int reviewId, int userId)
        {
            var review = await _reviewService.GetOne(reviewId);

            if (review == null)
            {
                throw new BadRequestException("Review does not exist")
                {
                    ErrorCode = "005"
                };
            }

            var like = await _likeRepository.GetOne(reviewId, userId);

            if (like == null)
            {
                throw new NotFoundException("No such like was found")
                {
                    ErrorCode = "004"
                };
            }

            return await _likeRepository.Delete(like);
        }

    }
}

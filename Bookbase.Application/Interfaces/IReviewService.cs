using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Interfaces
{
    public interface IReviewService : IBaseService<Review, CreateReviewResponseDto, ReviewResponseDto, CreateReviewDto, UpdateReviewDto>
    {
        public Task<IEnumerable<ReviewResponseDto>> GetBookReviews(int bookId);

        public Task<GenericResponseDto> Delete(int userId, int reviewId);
        public Task<CreateReviewResponseDto> Update(int userId, int reviewId, UpdateReviewDto body);

        //public Task<GenericListResponse<BookListResponseDto>> GetList(int? userId, int page, int pageSize);

    }
}

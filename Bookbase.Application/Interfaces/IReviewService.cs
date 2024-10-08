﻿using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface IReviewService
    {
        public Task<CreateReviewResponseDto> Create(CreateReviewDto reviewDto, int userId);

        public Task<ReviewResponseDto?> GetOne(int reviewId);

        public Task<IEnumerable<ReviewResponseDto>> GetBookReviews(int bookId);

        public Task<bool> Delete(int userId, int reviewId);

        //public Task<GenericListResponse<BookListResponseDto>> GetList(int? userId, int page, int pageSize);

    }
}

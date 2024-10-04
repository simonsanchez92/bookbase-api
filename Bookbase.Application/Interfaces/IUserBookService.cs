﻿using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Interfaces
{
    public interface IUserBookService
    {
        public Task<ShelfBookResponseDto> Add(int userId, int bookId);
        //public Task<IEnumerable<UserBookResponseDto>> GetList(int userId);

        public Task<GenericListResponse<UserBookResponseDto>> GetList(int? userId, int page, int pageSize);

        public Task<UserBookResponseDto?> GetOne(int userId, int bookId);

        public Task<UserBookResponseDto> UpsertUserBook(int userId, int bookId, Action<UserBook> updateField);

        public Task<UserBookResponseDto> UpdateReadingStatus(int userId, int bookId, UpdateReadingStatusDto updateReadingStatusDto);

        public Task<UserBookResponseDto> Rate(int userId, int bookId, RateBookDto rateBookDto);
        public Task<bool> Delete(int userId, int bookId);

    }
}

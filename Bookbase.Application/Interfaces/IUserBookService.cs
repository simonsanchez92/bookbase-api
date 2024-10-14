﻿using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Interfaces
{
    public interface IUserBookService
    {
        public Task<GenericListResponse<BookListResponseDto>> GetUserShelf(int userId, int page, int pageSize);

        public Task<BookListResponseDto> ShelveBook(int? userId, int bookId);



        public Task<UserBookResponseDto> UpsertUserBook(int userId, int bookId, Action<UserBook> updateField);


        public Task<UserBookResponseDto> UpdateReadingStatus(int userId, int bookId, UpdateReadingStatusDto updateReadingStatusDto);


        public Task<UserBookResponseDto> RateBook(int userId, int bookId, RateBookDto rateBookDto);

        public Task<bool> RemoveFromShelf(int userId, int bookId);
    }
}
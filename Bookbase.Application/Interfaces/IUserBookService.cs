﻿using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface IUserBookService
    {
        public Task<UserBookResponseDto> Add(int userId, int bookId);

        public Task<UserBookResponseDto?> GetOne(int userId, int bookId);

        public Task<UserBookResponseDto> Update(int userId, int BookId, UpdateUserBookDto userBookDto);

        public Task<bool> Delete(int userId, int bookId);

    }
}

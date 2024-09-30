using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface IUserBookService
    {
        public Task<ShelfBookResponseDto> Add(int userId, int bookId);

        //public Task<UserWithBooksResponseDto> GetAll(int userId);
        public Task<IEnumerable<UserBookResponseDto>> GetList(int userId);
        public Task<UserBookResponseDto?> GetOne(int userId, int bookId);

        public Task<UserBookResponseDto> UpdateReadingStatus(int userId, int bookId, UpdateReadingStatusDto updateReadingStatusDto);

        public Task<UserBookResponseDto> Rate(int userId, int bookId, RateBookDto rateBookDto);

        public Task<bool> Delete(int userId, int bookId);

    }
}

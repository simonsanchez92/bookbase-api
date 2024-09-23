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

        public Task<UserBookListResponseDto> Update(int userId, int BookId, UpdateUserBookDto userBookDto);

        public Task<bool> Delete(int userId, int bookId);

    }
}

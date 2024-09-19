using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface IUserBookService
    {
        public Task<UserBookResponseDto> Add(int userId, int bookId);

    }
}

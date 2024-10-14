using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;

namespace Bookbase.Application.Interfaces
{
    public interface IBookService
    {
        public Task<BookListResponseDto?> GetOne(int? userId, int bookId);

        public Task<GenericListResponse<BookListResponseDto>> GetList(int? userId, int page, int pageSize, string? query);

        Task<GenericResult<BookResponseDto>> Create(CreateBookDto bookDto);

        Task<BookResponseDto> Update(int bookId, UpdateBookDto userDto);


        public Task<bool> Delete(int bookId);

        public Task<IEnumerable<BookListResponseDto>> GetAll(int? userId);
    }
}

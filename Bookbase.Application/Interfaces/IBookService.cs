using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;

namespace Bookbase.Application.Interfaces
{
    public interface IBookService
    {
        public Task<BookResponseDto?> GetOne(int bookId);

        public Task<GenericListResponse<BookResponseDto>> GetList(int page, int pageSize);

        Task<IEnumerable<BookResponseDto>> GetAll();

        Task<GenericResult<BookResponseDto>> Create(CreateBookDto bookDto);

        Task<BookResponseDto> Update(int bookId, UpdateBookDto userDto);

        Task<bool> Delete(int bookId);


        Task<IEnumerable<BookResponseDto>> Search(string? title, string? author);


    }
}

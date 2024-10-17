using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Interfaces
{
    public interface IBookService : IBaseService<Book, BookResponseDto, BookDetailedResponseDto, CreateBookDto, UpdateBookDto>
    {
        public Task<BookDetailedResponseDto?> GetOne(int? userId, int bookId);

        public Task<GenericListResponse<BookDetailedResponseDto>> GetList(int? userId, int page, int pageSize, string? query);

        public Task<IEnumerable<BookDetailedResponseDto>> GetAll(int? userId);
    }
}

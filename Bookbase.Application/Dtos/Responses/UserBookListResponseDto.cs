using Bookbase.Domain.Common;

namespace Bookbase.Application.Dtos.Responses
{
    public class UserBookListResponseDto
    {
        public IEnumerable<BookResponse> Books { get; set; } = new List<BookResponse>();
    }
}

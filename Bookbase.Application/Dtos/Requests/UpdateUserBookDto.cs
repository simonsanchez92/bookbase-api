using Bookbase.Application.Enums;

namespace Bookbase.Application.Dtos.Requests
{
    public class UpdateUserBookDto
    {
        public required ReadingStatus Status { get; set; }
    }
}

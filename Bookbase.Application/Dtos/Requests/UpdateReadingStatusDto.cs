using Bookbase.Domain.Enums;

namespace Bookbase.Application.Dtos.Requests
{
    public class UpdateReadingStatusDto
    {
        public required ReadingStatus Status { get; set; }
    }
}

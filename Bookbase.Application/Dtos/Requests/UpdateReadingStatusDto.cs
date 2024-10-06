using Bookbase.Domain.Enums;

namespace Bookbase.Application.Dtos.Requests
{
    public class UpdateReadingStatusDto
    {
        public required ReadingStatusEnum Status { get; set; }
    }
}

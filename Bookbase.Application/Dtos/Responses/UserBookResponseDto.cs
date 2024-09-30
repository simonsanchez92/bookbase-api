namespace Bookbase.Application.Dtos.Responses
{
    public class UserBookResponseDto : BookResponseDto
    {
        //public UserResponseDto User { get; set; }
        public required string Status { get; set; }
        public float Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

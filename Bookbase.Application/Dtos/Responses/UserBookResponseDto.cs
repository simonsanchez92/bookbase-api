namespace Bookbase.Application.Dtos.Responses
{
    public class UserBookResponseDto
    {
        public UserResponseDto User { get; set; }
        public int BookId { get; set; }
        public string Status { get; set; }
    }
}

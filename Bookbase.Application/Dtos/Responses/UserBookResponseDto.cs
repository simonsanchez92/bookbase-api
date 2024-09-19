namespace Bookbase.Application.Dtos.Responses
{
    public class UserBookResponseDto
    {
        public UserResponseDto User { get; set; }
        public BookResponseDto Book { get; set; }
        public string Status { get; set; }
    }
}

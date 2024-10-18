namespace Bookbase.Application.Dtos.Requests
{
    public class SignInDto
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password1 { get; set; }
        public required string Password2 { get; set; }
    }
}

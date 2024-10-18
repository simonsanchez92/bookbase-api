namespace Bookbase.Application.Dtos.Requests
{
    public class SignInDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;


namespace Bookbase.Application.Interfaces
{
    public interface IAuthService
    {
        public Task<LoginResponseDto> Login(LoginDto userDto);

    }
}

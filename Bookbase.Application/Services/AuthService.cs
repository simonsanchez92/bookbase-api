using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Bookbase.Application.Services
{
    public class AuthService: IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly IPasswordEncryptionService _passwordEncryptionService;
        private readonly IJwtTokenService _jwtTokenService; 

        public AuthService(IConfiguration configuration, IUserService userService, IPasswordEncryptionService passwordEncryptionService, IJwtTokenService jwtTokenService)
        {
            _configuration = configuration;
            _userService = userService;
            _passwordEncryptionService = passwordEncryptionService;
            _jwtTokenService = jwtTokenService; 
        }


        public async Task<LoginResponseDto> Login(LoginRequestDto userDto)
        {
            var user = await _userService.GetOne(u => u.Email == userDto.Email);

            if (user == null)
            {
                //Todo - Invalid credentials (403)

                return null;
            }

            //Check password

            var isValid = _passwordEncryptionService.VerifyPassword(user.Password, userDto.Password);

            if (!isValid)
            {
                //Todo - Invalid Password (403)

            }

            //Generate token
            string token = _jwtTokenService.GenerateJwtToken(user);
            
            return new LoginResponseDto() { Token = token };
        }

    }
}

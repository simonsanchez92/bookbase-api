using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Enums;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Bookbase.Application.Services
{
    public class AuthService: IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordEncryptionService _passwordEncryptionService;
        private readonly IConfiguration _configuration;

        public AuthService(IAuthRepository authRepository, IPasswordEncryptionService passwordEncryptionService, IConfiguration configuration)
        {
            _authRepository = authRepository;
            _passwordEncryptionService = passwordEncryptionService;
            _configuration = configuration;
        }

        public async Task<LoginResponseDto> Login(LoginDto userDto)
        {
            var user = await _authRepository.Login(userDto.Email);

            if (user == null || !_passwordEncryptionService.VerifyPassword(user.Password, userDto.Password)){

                return null;
            }

            string token = GenerateJwtToken(user);

            //return 
            return new LoginResponseDto() {Token = token };    
        }


        //JWT generator
        private string GenerateJwtToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


         

            //Key-Value pair that represent user data that can be encoded into the JWT
            //These claims are included in the payload of the token
            var claims = new[]
            {
                //Identifies the principal (User) that is the subject of the JWT
                    new Claim(JwtRegisteredClaimNames.Sub, user.Username), //Sub (subject)

                //User Email
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),

                ////User Role                   
                    //Int representation of role
                    //new Claim(ClaimTypes.Role, user.RoleId.ToString()),
                  
                    //String representation of role
                  new Claim(ClaimTypes.Role, Enum.GetName(typeof(UserRoleEnum), user.RoleId)),
                
                    //Unique identifier of the token, typically a GUID
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), //JWT ID

            };

            var token = new JwtSecurityToken(
             issuer: _configuration["Jwt:Issuer"],  //Specifies entity issuing the token
             audience: _configuration["Jwt:Audience"], //Speficies the recipient of the token
             claims: claims,
             expires: DateTime.Now.AddMinutes(30),
             signingCredentials: credentials );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

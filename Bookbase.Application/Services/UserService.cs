using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Common;
using Bookbase.Domain.Models;
using System.Linq.Expressions;
using Bookbase.Application.Exceptions;

namespace Bookbase.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordEncryptionService _passwordEncryptionService;
        private readonly IUserCreateValidatorService _userCreateValidatorService;
        private readonly IMapper _mapper;

 
        public UserService(IUserRepository userRepository, IPasswordEncryptionService passwordEncryptionService, IMapper mapper, IUserCreateValidatorService userCreateValidator)
        {
            _userRepository = userRepository;
            _passwordEncryptionService = passwordEncryptionService;
            _mapper = mapper;
            _userCreateValidatorService = userCreateValidator;
        }


        public async Task<UserResponseDto?> GetOne(int userId)
        {
            var user = await _userRepository.GetOne(userId);

            if(user == null)
            {
                throw new NotFoundException("User not found")
                {
                    ErrorCode= "003"
                };
            }
            
            return _mapper.Map<UserResponseDto>(user);
        }


        public async Task<User> GetOne(Expression<Func<User, bool>> predicate)
        {
            return await _userRepository.GetOne(predicate);
        }


        public async Task<IEnumerable<UserResponseDto>> GetAll()
        {
            
            var users = await _userRepository.GetAll();
            
            if (!users.Any())
            {
                throw new UnauthorizedException("Unauthorized")
                {
                    ErrorCode = "004"
                };
            }

            return _mapper.Map<IEnumerable<UserResponseDto>>(users);

        }

        public async Task<GenericResult<UserResponseDto>> Create(CreateUserDto userDto)
        {
            var newUser = new User
            {
                Username = userDto.Username,
                Email = userDto.Email,
                Password = userDto.Password, //PLain text
                RoleId = userDto.RoleId
            };

            var validation = await _userCreateValidatorService.Validate(newUser);

            if (!validation.Success)
            {
                return GenericResult<UserResponseDto>.FailureResult(validation.Messages);
            }
        
            //Hash and store password
            newUser.Password = _passwordEncryptionService.HashPassword(userDto.Password);

            var user = await _userRepository.Create(newUser);

            var data = _mapper.Map<UserResponseDto>(user);

            return GenericResult<UserResponseDto>.SuccessResult(data);
            
        }

        public async Task<UserResponseDto> Update(int userId, UpdateUserDto userDto)
        {
            var user = new User
            {
                Username = userDto.Username,
                Email = string.Empty,
                Password = _passwordEncryptionService.HashPassword(userDto.Password),
                RoleId = userDto.RoleId,
            };

            var updatedUser = await _userRepository.Update(userId, user);

            return _mapper.Map<UserResponseDto>(updatedUser);
        }

        public async Task<bool> Delete(int userId)
        {
            var user = await _userRepository.GetOne(userId);

            if(user == null)
            {
                return false;
            }

            user.Deleted = true;
            await _userRepository.Update(userId, user);

            return true;
        }

    }
}

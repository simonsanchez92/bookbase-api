using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
using Bookbase.Application.Utilities;
using Bookbase.Application.Validators;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordEncryptionService _passwordEncryptionService;
        private readonly IUserCreateValidator _userCreateValidator;
        private readonly IMapper _mapper;

 
        public UserService(IUserRepository userRepository, IPasswordEncryptionService passwordEncryptionService, IMapper mapper, IUserCreateValidator userCreateValidator)
        {
            _userRepository = userRepository;
            _passwordEncryptionService = passwordEncryptionService;
            _mapper = mapper;
            _userCreateValidator = userCreateValidator;
        }


        public async Task<UserResponseDto> GetOne(int userId)
        {
            var user = await _userRepository.GetOne(userId);
            return _mapper.Map<UserResponseDto>(user);
        }


        public async Task<User> GetOne(Expression<Func<User, bool>> predicate)
        {
            return await _userRepository.GetOne(predicate);
        }


        public async Task<IEnumerable<UserResponseDto>> GetAll()
        {
            var users = await _userRepository.GetAll();

            return _mapper.Map<IEnumerable<UserResponseDto>>(users);
             
        }

        public async Task<GenericResult<UserResponseDto>> Create(CreateUserDto userDto)
        {
            //var validationErrors = await ValidateUserCreateDto(userDto);
            var validation = await _userCreateValidator.Validate(userDto);


            if (!validation.Success)
            {
                return GenericResult<UserResponseDto>.FailureResult(validation.Messages);
            }
        
            var newUser = new User
            {
                Username = userDto.Username,
                Email = userDto.Email,
                Password = _passwordEncryptionService.HashPassword(userDto.Password),
                RoleId = userDto.RoleId,
            };


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

using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
using Bookbase.Application.Validators;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordEncryptionService _passwordEncryptionService;
        private readonly IMapper _mapper;

 
        public UserService(IUserRepository userRepository, IPasswordEncryptionService passwordEncryptionService, IMapper mapper)
        {
            _userRepository = userRepository;
            _passwordEncryptionService = passwordEncryptionService;
            _mapper = mapper;
        }

        public async Task<UserResponseDto> GetOne(int userId)
        {
            var filtersById = new Dictionary<string, object> { { "id", userId } };
            var user = await _userRepository.GetOne(filtersById);

            return _mapper.Map<UserResponseDto>(user);
        }


        public async Task<IEnumerable<UserResponseDto>> GetAll()
        {
            var users = await _userRepository.GetAll();

            return _mapper.Map<IEnumerable<UserResponseDto>>(users);
             
        }



        public async Task<UserResponseDto> Create(CreateUserDto userDto)
        {
            var validationErrors = await ValidateUserCreateDto(userDto);

            if (validationErrors.Count != 0) return null;

            var newUser = new User
            {
                Username = userDto.Username,
                Email = userDto.Email,
                Password = _passwordEncryptionService.HashPassword(userDto.Password),
                RoleId = userDto.RoleId,
            };


            var user = await _userRepository.Create(newUser);


            return _mapper.Map<UserResponseDto>(user);

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
            return await _userRepository.Delete(userId);
        }


        private async Task<List<string>> ValidateUserCreateDto(CreateUserDto userDto)
        {

            List<string> errMessages = new List<string>();
            var validator = new CreateUserDtoValidator();
            var validationResult = validator.Validate(userDto);


            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    errMessages.Add(error.ErrorMessage);
                }
            }

            //Check if username exists
            if (await _userRepository.GetOne(new Dictionary<string, object> { { "username", userDto.Username } }) != null)
            {
                string msg = $"Username '{userDto.Username}' is already taken.";
                errMessages.Add(msg);
            }

            //Check if email exists
            if (await _userRepository.GetOne(new Dictionary<string, object> { { "email", userDto.Email } }) != null)
            {
                string msg = $"Email '{userDto.Email}' is already taken.";
                errMessages.Add(msg);

            }

            return errMessages;
        }
    }
}

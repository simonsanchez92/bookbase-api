using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
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
            var user = await _userRepository.GetOne(userId);

            return _mapper.Map<UserResponseDto>(user);
        }


        public async Task<IEnumerable<UserResponseDto>> GetAll()
        {
            var users = await _userRepository.GetAll();

            return _mapper.Map<IEnumerable<UserResponseDto>>(users);
            
            
        }


        public async Task<UserResponseDto> Create(CreateUserDto userDto)
        {
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
    }
}

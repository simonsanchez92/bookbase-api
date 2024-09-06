using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface IUserService
    {
        public Task<UserResponseDto> GetOne(int userId);
        Task<IEnumerable<UserResponseDto>> GetAll();
        Task<UserResponseDto> Create(CreateUserDto userDto);
        
        Task<UserResponseDto> Update(int userId, UpdateUserDto userDto);

    }
}

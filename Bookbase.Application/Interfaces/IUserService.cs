using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;
using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Application.Interfaces
{
    public interface IUserService
    {
        public Task<UserResponseDto?> GetOne(int userId);
        public Task<User> GetOne(Expression<Func<User, bool>> predicate);

        Task<IEnumerable<UserResponseDto>> GetAll();

        Task<GenericResult<UserResponseDto>> Create(CreateUserDto userDto);

        Task<UserResponseDto> Update(int userId, UpdateUserDto userDto);

        Task<bool> Delete(int userId);

    }
}

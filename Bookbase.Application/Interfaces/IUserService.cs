using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Application.Interfaces
{
    public interface IUserService : IBaseService<User, UserResponseDto, UserResponseDto, CreateUserDto, UpdateUserDto>
    {
        //public Task<UserResponseDto?> GetOne(int userId);
        public Task<User?> GetOne(Expression<Func<User, bool>> predicate);

        //Task<IEnumerable<UserResponseDto>> GetAll();


    }
}

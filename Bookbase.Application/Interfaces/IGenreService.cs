using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface IGenreService
    {
        //public Task<UserResponseDto?> GetOne(int userId);
        //public Task<User> GetOne(Expression<Func<User, bool>> predicate);

        Task<IEnumerable<GenreResponseDto>> GetAll();

        //Task<GenericResult<UserResponseDto>> Create(CreateUserDto userDto);

        //Task<UserResponseDto> Update(int userId, UpdateUserDto userDto);

        //Task<bool> Delete(int userId);

    }
}

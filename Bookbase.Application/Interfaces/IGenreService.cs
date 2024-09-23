using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Application.Interfaces
{
    public interface IGenreService
    {
        public Task<GenreResponseDto?> GetOne(int genreId);
        public Task<Genre> GetOne(Expression<Func<Genre, bool>> predicate);
        Task<IEnumerable<GenreResponseDto>> GetAll();
        Task<GenreResponseDto> Create(CreateGenreDto userDto);

        //Task<UserResponseDto> Update(int userId, UpdateUserDto userDto);

        //Task<bool> Delete(int userId);

    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Interfaces
{
    public interface IGenreService : IBaseService<Genre, GenreResponseDto, GenreResponseDto, CreateGenreDto, CreateGenreDto>
    {
    }
}

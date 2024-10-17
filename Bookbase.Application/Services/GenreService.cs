using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class GenreService : BaseService<Genre, GenreResponseDto, GenreResponseDto, CreateGenreDto, CreateGenreDto>, IGenreService
    {
        private new readonly IGenreRepository _repository;
        public GenreService(IGenreRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        public override async Task<GenreResponseDto> Create(CreateGenreDto body)
        {
            var genreExists = await _repository.GetOne(g => g.Name == body.Name);

            if (genreExists != null)
            {
                throw new BadRequestException($"Genre with name '{body.Name}' already exists")
                {
                    ErrorCode = "006"
                };
            }

            return await base.Create(body);
        }


    }
}

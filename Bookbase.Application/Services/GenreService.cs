using AutoMapper;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;

namespace Bookbase.Application.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;


        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GenreResponseDto>> GetAll()
        {
            var genres = await _genreRepository.GetAll();

            return _mapper.Map<IEnumerable<GenreResponseDto>>(genres);
        }
    }
}

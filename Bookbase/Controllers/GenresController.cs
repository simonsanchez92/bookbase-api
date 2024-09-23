using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet("{genreId}")]
        public async Task<IActionResult> GetOne(int genreId)
        {
            var genre = await _genreService.GetOne(genreId);

            return Ok(genre);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _genreService.GetAll();

            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateGenreDto genreDto)
        {
            var genre = await _genreService.Create(genreDto);

            return CreatedAtAction(
                     actionName: nameof(GetOne),
                     routeValues: new { genreId = genre.Id },
                     value: genre
                 );

        }

    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }



        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetOne(int bookId)
        {
            var res = await _bookService.GetOne(bookId);

            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _bookService.GetAll();

            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookDto bookDto)
        {
            var bookResponse = await _bookService.Create(bookDto);

            //Returns 201
            // Assuming the userResponse contains the ID of the newly created user.
            if (bookResponse.Success)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne), // The action that retrieves the created resource
                    routeValues: new { bookId = bookResponse.Data.Id }, // Route values to populate the URL for the location header
                    value: bookResponse.Data
                );
            }
            //Returns 409
            return Conflict(bookResponse.Messages);

        }


        [HttpPut("{bookId}")]
        public async Task<IActionResult> Update(int bookId, [FromBody] UpdateBookDto bookDto)
        {
            var user = await _bookService.Update(bookId, bookDto);
            return Ok(user);
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] string? title, [FromQuery] string? author)
        {
            var res = await _bookService.Search(title, author);

            return Ok(res);
        }
    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Bookbase.Helpers;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Policy = "AdminOnly")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookDto bookDto)
        {
            var bookResponse = await _bookService.Create(bookDto);

            //Returns 201
            // Assuming the userResponse contains the ID of the newly created user.
            if (bookResponse != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne), // The action that retrieves the created resource
                    routeValues: new { bookId = bookResponse.Id }, // Route values to populate the URL for the location header
                    value: bookResponse
                );
            }
            //Returns 409
            return Conflict();
        }


        [HttpGet("show/{bookId}")]
        public async Task<IActionResult> GetOne(int bookId)
        {
            var userId = UserHelper.GetOptionalUserId(User);

            var res = await _bookService.GetOne(userId, bookId);

            return Ok(res);

        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] int page, [FromQuery] int pageSize, [FromQuery] string? query)
        {
            var userId = UserHelper.GetOptionalUserId(User);
            var books = await _bookService.GetList(userId, page, pageSize, query);

            return Ok(books);
        }


        [HttpGet("all")]
        public async Task<IActionResult> GetAl()
        {
            var userId = UserHelper.GetOptionalUserId(User);
            var books = await _bookService.GetAll(userId);

            return Ok(books);
        }

        [Authorize(Policy = "AdminOnly")]
        [HttpPut("{bookId}")]
        public async Task<IActionResult> Update(int bookId, [FromBody] UpdateBookDto bookDto)
        {
            var user = await _bookService.Update(bookId, bookDto);
            return Ok(user);
        }



        [Authorize(Policy = "AdminOnly")]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedBook = await _bookService.Delete(id);
            return Ok(deletedBook);
        }
    }
}

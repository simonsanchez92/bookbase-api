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


        [HttpGet("show/{bookId}")]
        public async Task<IActionResult> GetOne(int bookId)
        {
            var userId = UserHelper.GetUserId(User);

            var res = await _bookService.GetOne(userId, bookId);

            return Ok(res);

        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] int page, [FromQuery] int pageSize)
        {
            var userId = UserHelper.GetUserId(User);
            var books = await _bookService.GetList(userId, page, pageSize);

            return Ok(books);
        }


        [Authorize(Policy = "AdminOnly")]
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


        [Authorize(Policy = "AdminOnly")]
        [HttpPut("{bookId}")]
        public async Task<IActionResult> Update(int bookId, [FromBody] UpdateBookDto bookDto)
        {
            var user = await _bookService.Update(bookId, bookDto);
            return Ok(user);
        }



        [HttpPost("shelve")]
        public async Task<IActionResult> ShelveBook([FromBody] ShelveBookDto shelveBookDto)
        {

            var userId = UserHelper.GetUserId(User);


            var shelveBookResponse = await _bookService.ShelveBook(userId, shelveBookDto.BookId);

            //Returns 201
            if (shelveBookResponse != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne),
                    routeValues: new { userId = shelveBookResponse.UserId, bookId = shelveBookResponse.BookId },
                    value: shelveBookResponse
                );
            }

            //Returns 409
            return Conflict();

        }
    }
}

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
            var books = await _bookService.GetAll();

            return Ok(books);
        }




        [Authorize(Policy = "AdminOnly")]
        [HttpPut("{bookId}")]
        public async Task<IActionResult> Update(int bookId, [FromBody] UpdateBookDto bookDto)
        {
            var user = await _bookService.Update(bookId, bookDto);
            return Ok(user);
        }



        [Authorize(Policy = "AuthenticatedUser")]
        [HttpGet("review/list")]
        public async Task<IActionResult> GetUserShelf([FromQuery] int page, [FromQuery] int pageSize)
        {
            var userId = UserHelper.GetRequiredUserId(User);
            var books = await _bookService.GetUserShelf(userId, page, pageSize);

            return Ok(books);
        }


        [HttpPost("shelve")]
        public async Task<IActionResult> ShelveBook([FromBody] ShelveBookDto shelveBookDto)
        {

            var userId = UserHelper.GetRequiredUserId(User);


            var shelveBookResponse = await _bookService.ShelveBook(userId, shelveBookDto.BookId);

            //Returns 201
            if (shelveBookResponse != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne),
                    routeValues: new { bookId = shelveBookResponse.Book.Id },
                    value: shelveBookResponse
                );
            }

            //Returns 409
            return Conflict();
        }

        [Authorize(Policy = "AuthenticatedUser")]
        [HttpPut("{bookId}/update-status")]
        public async Task<IActionResult> UpdateStatus(int bookId, [FromBody] UpdateReadingStatusDto updateReadingStatusDto)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var userBook = await _bookService.UpdateReadingStatus(userId, bookId, updateReadingStatusDto);


            return Ok(userBook);
        }

        [Authorize(Policy = "AuthenticatedUser")]
        [HttpPut("{bookId}/rate")]
        public async Task<IActionResult> RateBook(int bookId, [FromBody] RateBookDto rateBookDto)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var userBook = await _bookService.RateBook(userId, bookId, rateBookDto);


            return Ok(userBook);
        }


        [Authorize(Policy = "AuthenticatedUser")]
        [HttpDelete("{bookId}/remove")]
        public async Task<IActionResult> RemoveFromShelf(int bookId)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var userBookDeleted = await _bookService.RemoveFromShelf(userId, bookId);

            return Ok(userBookDeleted);
        }
    }
}

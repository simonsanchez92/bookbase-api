using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Bookbase.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBooksController : ControllerBase
    {
        private readonly IUserBookService _userBookService;
        private readonly IBookService _bookService;

        public UserBooksController(IUserBookService userBookService, IBookService bookService)
        {
            _userBookService = userBookService;
            _bookService = bookService;
        }

        //[Authorize(Policy = "AuthenticatedUser")]
        //[HttpGet("review/list")]
        //public async Task<IActionResult> GetUserShelf([FromQuery] int page, [FromQuery] int pageSize)
        //{
        //    var userId = UserHelper.GetRequiredUserId(User);
        //    var books = await _bookService.GetUserShelf(userId, page, pageSize);

        //    return Ok(books);
        //}

        [HttpGet("get")]

        public async Task<IActionResult> GetOne(int bookId)
        {
            var userId = UserHelper.GetOptionalUserId(User);

            var res = await _bookService.GetOne(userId, bookId);

            return Ok(res);

        }

        [HttpPost("shelve")]
        public async Task<IActionResult> ShelveBook([FromBody] ShelveBookDto shelveBookDto)
        {

            var userId = UserHelper.GetRequiredUserId(User);


            var shelveBookResponse = await _userBookService.ShelveBook(userId, shelveBookDto.BookId);

            //Returns 201
            if (shelveBookResponse != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne),
                    routeValues: new { shelveBookResponse.Book.Id },
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

            var userBook = await _userBookService.UpdateReadingStatus(userId, bookId, updateReadingStatusDto);


            return Ok(userBook);
        }

        [Authorize(Policy = "AuthenticatedUser")]
        [HttpPut("{bookId}/rate")]
        public async Task<IActionResult> RateBook(int bookId, [FromBody] RateBookDto rateBookDto)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var userBook = await _userBookService.RateBook(userId, bookId, rateBookDto);


            return Ok(userBook);
        }


        [Authorize(Policy = "AuthenticatedUser")]
        [HttpDelete("{bookId}/remove")]
        public async Task<IActionResult> RemoveFromShelf(int bookId)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var userBookDeleted = await _userBookService.RemoveFromShelf(userId, bookId);

            return Ok(userBookDeleted);
        }
    }
}

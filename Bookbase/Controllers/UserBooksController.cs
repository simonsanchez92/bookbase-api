using Bookbase.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBooksController : ControllerBase
    {
        private readonly IUserBookService _userBookService;

        public UserBooksController(IUserBookService userBookService)
        {
            _userBookService = userBookService;
        }


        //[HttpGet("show/{bookId}")]
        //public async Task<IActionResult> GetOne(int bookId)
        //{
        //    var userId = UserHelper.GetUserId(User);

        //    var userBook = await _userBookService.GetOne(userId, bookId);

        //    return Ok(userBook);
        //}

        //[HttpGet("list")]
        //public async Task<IActionResult> GetList()
        //{
        //    var userId = UserHelper.GetUserId(User);
        //    var userBooks = await _userBookService.GetList(userId);

        //    return Ok(userBooks);
        //}

        //[HttpGet("list")]
        //public async Task<IActionResult> GetList([FromQuery] int page, [FromQuery] int pageSize)
        //{
        //    var userId = UserHelper.GetUserId(User);
        //    var userBooks = await _userBookService.GetList(userId, page, pageSize);

        //    return Ok(userBooks);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] CreateUserBookDto userBookDto)
        //{

        //    var userId = UserHelper.GetUserId(User);


        //    var userBookResponse = await _userBookService.Add(userId, userBookDto.BookId);

        //    //Returns 201
        //    if (userBookResponse != null)
        //    {
        //        return CreatedAtAction(
        //            actionName: nameof(GetOne),
        //            routeValues: new { userId = userBookResponse.UserId, bookId = userBookResponse.BookId },
        //            value: userBookResponse
        //        );
        //    }

        //    //Returns 409
        //    return Conflict();

        //}


        //[HttpPut("{bookId}/edit-status")]
        //public async Task<IActionResult> EditStatus(int bookId, [FromBody] UpdateReadingStatusDto updateReadingStatusDto)
        //{
        //    var userId = UserHelper.GetUserId(User);

        //    var userBook = await _userBookService.UpdateReadingStatus(userId, bookId, updateReadingStatusDto);


        //    return Ok(userBook);
        //}

        //[HttpPut("{bookId}/rate")]
        //public async Task<IActionResult> Rate(int bookId, [FromBody] RateBookDto rateBookDto)
        //{
        //    var userId = UserHelper.GetUserId(User);

        //    var userBook = await _userBookService.Rate(userId, bookId, rateBookDto);


        //    return Ok(userBook);
        //}


        //[HttpDelete("{bookId}/delete")]
        //public async Task<IActionResult> Delete(int bookId)
        //{
        //    var userId = UserHelper.GetUserId(User);

        //    var userBookDeleted = await _userBookService.Delete(userId, bookId);

        //    return Ok(userBookDeleted);
        //}
    }
}

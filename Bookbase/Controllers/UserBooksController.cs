using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Bookbase.Helpers;
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


        [HttpGet("{userId}/{bookId}")]
        public async Task<IActionResult> GetOne(int userId, int bookId)
        {
            var userBook = await _userBookService.GetOne(userId, bookId);

            return Ok(userBook);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var userId = UserHelper.GetUserId(User);
            var userBooks = await _userBookService.GetList(userId);

            return Ok(userBooks);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserBookDto userBookDto)
        {

            var userId = UserHelper.GetUserId(User);


            var userBookResponse = await _userBookService.Add(userId, userBookDto.BookId);

            //Returns 201
            if (userBookResponse != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne),
                    routeValues: new { userId = userBookResponse.UserId, bookId = userBookResponse.BookId },
                    value: userBookResponse
                );
            }

            //Returns 409
            return Conflict();

        }


        [HttpPut("{bookId}")]
        public async Task<IActionResult> Update(int bookId, [FromBody] UpdateUserBookDto userBookDto)
        {
            var userId = UserHelper.GetUserId(User);

            var userBook = await _userBookService.Update(userId, bookId, userBookDto);


            return Ok(userBook);
        }


        [HttpDelete("{bookId}/delete")]
        public async Task<IActionResult> Delete(int bookId)
        {
            var userId = UserHelper.GetUserId(User);

            var userBookDeleted = await _userBookService.Delete(userId, bookId);

            return Ok(userBookDeleted);
        }
    }
}

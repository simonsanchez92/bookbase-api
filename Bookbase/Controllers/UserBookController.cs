using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBookController : ControllerBase
    {
        private readonly IUserBookService _userBookService;

        public UserBookController(IUserBookService userBookService)
        {
            _userBookService = userBookService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserBookDto userBookDto)
        {
            var userBookResponse = await _userBookService.Add(userBookDto.UserId, userBookDto.BookId);

            //Returns 201
            // Assuming the userResponse contains the ID of the newly created user.
            //if (userBookResponse.Success)
            //{
            //    return CreatedAtAction(
            //        actionName: nameof(GetOne), // The action that retrieves the created resource
            //        routeValues: new { bookId = bookResponse.Data.Id }, // Route values to populate the URL for the location header
            //        value: bookResponse.Data
            //    );
            //}

            if (userBookResponse != null)
            {

                return Ok(userBookResponse);
            }

            //Returns 409
            return Conflict();

        }
    }
}

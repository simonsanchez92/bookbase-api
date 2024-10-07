using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Bookbase.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }


        [Authorize(Policy = "AuthenticatedUser")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReviewDto reviewDto)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var reviewResponse = await _reviewService.Create(reviewDto, userId);

            //Returns 201
            // Assuming the userResponse contains the ID of the newly created user.
            if (reviewResponse != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne), // The action that retrieves the created resource
                    routeValues: new { reviewId = reviewResponse.Id }, // Route values to populate the URL for the location header
                    value: reviewResponse
                );
            }
            //Returns 409
            return Conflict();
        }


        [HttpGet("show/{reviewId}")]
        public async Task<IActionResult> GetOne(int reviewId)
        {

            var res = await _reviewService.GetOne(reviewId);

            return Ok(res);

        }

        //[HttpGet]
        //public async Task<IActionResult> GetList([FromQuery] int page, [FromQuery] int pageSize)
        //{
        //    var userId = UserHelper.GetOptionalUserId(User);
        //    var books = await _bookService.GetList(userId, page, pageSize);

        //    return Ok(books);
        //}
    }
}

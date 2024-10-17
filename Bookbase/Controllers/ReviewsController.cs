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
        public async Task<IActionResult> Create([FromBody] CreateReviewDto body)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            body.UserId = userId;

            var reviewResponse = await _reviewService.Create(body);

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

        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBookReviews(int bookId)
        {
            var res = await _reviewService.GetBookReviews(bookId);

            return Ok(res);
        }

        [HttpPut("{reviewId}")]
        public async Task<IActionResult> UpdateReview([FromBody] UpdateReviewDto body, int reviewId)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var res = await _reviewService.Update(userId, reviewId, body);

            return Ok(res);
        }

        [HttpDelete("{reviewId}/delete")]
        public async Task<IActionResult> DeleteReview(int reviewId)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var res = await _reviewService.Delete(userId, reviewId);

            return Ok(res);
        }

    }
}

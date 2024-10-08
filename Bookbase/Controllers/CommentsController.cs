using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Bookbase.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }


        [HttpPost("{reviewId}")]
        public async Task<IActionResult> Create(int reviewId, [FromBody] CreateCommentDto commentDto)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var commentResponse = await _commentService.Create(reviewId, userId, commentDto);

            //Returns 201
            // Assuming the userResponse contains the ID of the newly created user.
            if (commentResponse != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne), // The action that retrieves the created resource
                    routeValues: new { commentId = commentResponse.Id }, // Route values to populate the URL for the location header
                    value: commentResponse
                );
            }
            //Returns 409
            return Conflict();
        }


        [HttpGet("{commentId}")]
        public async Task<IActionResult> GetOne(int commentId)
        {
            var res = await _commentService.GetOne(commentId);

            return Ok(res);

        }

    }
}

﻿using Bookbase.Application.Dtos.Requests;
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
                    routeValues: new { reviewId, commentId = commentResponse.Id }, // Route values to populate the URL for the location header
                    value: commentResponse
                );
            }
            //Returns 409
            return Conflict();
        }



        [HttpGet("/api/reviews/{reviewId}/comments/{commentId}")]
        public async Task<IActionResult> GetOne(int reviewId, int commentId)
        {
            var res = await _commentService.GetOne(reviewId, commentId);

            return Ok(res);

        }


        [HttpGet("{reviewId}/list")]
        public async Task<IActionResult> GetList(int reviewId, [FromQuery] int page, [FromQuery] int pageSize)
        {
            var comments = await _commentService.GetList(reviewId, page, pageSize);

            return Ok(comments);
        }


        [HttpDelete("/api/reviews/{reviewId}/comments/{commentId}/delete")]
        public async Task<IActionResult> DeleteReview(int reviewId, int commentId)
        {
            var userId = UserHelper.GetRequiredUserId(User);

            var res = await _commentService.Delete(reviewId, commentId, userId);

            return NoContent();
        }

    }
}

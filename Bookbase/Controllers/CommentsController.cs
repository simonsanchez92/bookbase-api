using Bookbase.Application.Interfaces;
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




        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] CreateCommentDto commentDto)
        //{
        //    var commentResponse = await _commentService.Create(commentDto);

        //    //Returns 201
        //    // Assuming the userResponse contains the ID of the newly created user.
        //    if (commentResponse != null)
        //    {
        //        return CreatedAtAction(
        //            actionName: nameof(GetOne), // The action that retrieves the created resource
        //            routeValues: new { bookId = bookResponse.Data.Id }, // Route values to populate the URL for the location header
        //            value: bookResponse.Data
        //        );
        //    }
        //    //Returns 409
        //    return Conflict(bookResponse.Messages);
        //}


        [HttpGet("{commentId}")]
        public async Task<IActionResult> GetOne(int commentId)
        {
            var res = await _commentService.GetOne(commentId);

            return Ok(res);

        }

    }
}

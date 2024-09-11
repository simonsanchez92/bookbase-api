using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("{userId}")]
        public async Task<IActionResult> GetOne(int userId)
        {
            var res = await _userService.GetOne(userId);

            if (res == null) return NotFound($"User with Id {userId} not found");

            return Ok(res);
        }
        
        
        [Authorize(Policy = "AdminOnly")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _userService.GetAll();

            return Ok(res);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserDto userDto)
        {
            var userResponse = await _userService.Create(userDto);

            //Returns 201
            // Assuming the userResponse contains the ID of the newly created user.
            if (userResponse.Success)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne), // The action that retrieves the created resource
                    routeValues: new { userId = userResponse.Data.Id }, // Route values to populate the URL for the location header
                    value: userResponse.Data
                );
            }

            //Returns 409
            return Conflict(userResponse.Messages);

        }


        [HttpPut("{userId}")]
        public async Task<IActionResult> Update(int userId, [FromBody] UpdateUserDto userDto)
        {
            var user = await _userService.Update(userId, userDto);
            return Ok(user);
        }


        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(int userId)
        {
            var userDeleted = await _userService.Delete(userId);

            return Ok(userDeleted);
        }
    }
}

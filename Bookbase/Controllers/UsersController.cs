using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Models;
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

            if (res == null) return NotFound();

            return Ok(res);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _userService.GetAll();

            return Ok(res);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserDto userDto)
        {
            var user = await _userService.Create(userDto);

            if (user.Success) return Ok(user);

            return Conflict(user.Messages);

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

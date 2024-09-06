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
            return Ok(user);
        }


        [HttpPut("{userId}")]
        public async Task<IActionResult> Update(int userId, [FromBody] UpdateUserDto userDto)
        {
            var user = await _userService.Update(userId, userDto);
            return Ok(user);
        }
    }
}

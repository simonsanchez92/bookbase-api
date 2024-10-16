using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
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

        [Authorize(Policy = "AdminOnly")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _userService.GetAll();
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserDto userDto, IValidator<CreateUserDto> validator)
        {

            var validationResults = await validator.ValidateAsync(userDto);

            if (!validationResults.IsValid)
            {
                throw new BadRequestException(validationResults.ToString())
                {
                    ErrorCode = "004"
                };
            }

            var user = await _userService.Create(userDto);
            //return Ok(user);

            ////Returns 201
            if (user != null)
            {
                return CreatedAtAction(
                    actionName: nameof(GetOne), // The action that retrieves the created resource
                    routeValues: new { userId = user.Id }, // Route values to populate the URL for the location header
                    value: user
                );
            }
            ////Returns 409
            return Conflict();

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

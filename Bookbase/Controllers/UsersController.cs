using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Helpers;
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

        [Authorize(Policy = "AdminOnly")]
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


        [HttpPost("signIn")]
        public async Task<IActionResult> SignIn([FromBody] SignInDto signInDto, IValidator<SignInDto> validator)
        {
            var validationResults = await validator.ValidateAsync(signInDto);

            if (!validationResults.IsValid)
            {
                throw new BadRequestException(validationResults.ToString())
                {
                    ErrorCode = "004"
                };
            }

            var user = await _userService.SignIn(signInDto);

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


        [Authorize(Policy = "AdminOnly")]
        [HttpPut("{userId}")]
        public async Task<IActionResult> Update(int userId, [FromBody] UpdateUserDto userDto)
        {
            var user = await _userService.Update(userId, userDto);
            return Ok(user);
        }

        [HttpPut("updatePassword")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordDto updatePasswordDto, IValidator<UpdatePasswordDto> validator)
        {

            int userId = UserHelper.GetRequiredUserId(User);

            var validationResults = await validator.ValidateAsync(updatePasswordDto);

            if (!validationResults.IsValid)
            {
                throw new BadRequestException(validationResults.ToString())
                {
                    ErrorCode = "004"
                };
            }

            var isPasswordUpdated = await _userService.UpdatePassword(userId, updatePasswordDto);

            if (isPasswordUpdated)
            {
                return Ok("Password updated successfully");
            }

            return Conflict("Failed to update password");

        }


        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(int userId)
        {
            var userDeleted = await _userService.Delete(userId);

            return Ok(userDeleted);
        }
    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bookbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginDto)
        {
            var res = await _authService.Login(loginDto);

            if(res == null) return NotFound();

            return Ok(res);
        }
    }
}

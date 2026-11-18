using BookingApi.Dtos;
using BookingApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingApi.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto regData)
        {
            var user = await _authService.RegisterAsync(regData);
            return Ok(user);
        }
    }
}
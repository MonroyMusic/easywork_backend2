using easywork_backend.Dtos.Security;
using easywork_backend.Dtos;
using easywork_backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using easywork_backend.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace easywork_backend.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {

            _authService = authService;

        }

        [HttpPost("login")]
        public async Task<ActionResult<ResponseDto<LoginResponseDto>>> Login(LoginDto dto)
        {

            var authResponse = await _authService.LoginAsync(dto);

            return StatusCode(authResponse.StatusCode, authResponse);

        }

        [HttpPost("refresh-token")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<ResponseDto<LoginResponseDto>>> RefreshToken()
        {

            var authResponse = await _authService.RefreshTokenAsync();

            return StatusCode(authResponse.StatusCode, authResponse);

        }

    }
}

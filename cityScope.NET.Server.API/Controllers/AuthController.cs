using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Pkcs;

namespace cityScope.NET.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

       public AuthController(IUserService userService)
       {
            _userService = userService;
       }

        [HttpPost("Register")]
        public async Task<ActionResult<BaseResponse<int>>> Register(UserRegisterDto registerDto)
        {
            var response = await _userService.Register(registerDto, registerDto.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<BaseResponse<string>>> Login(UserLoginDto loginDto)
        {
            var response = await _userService.Login(loginDto);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}

using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cityScope.NET.Server.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<BaseResponse<bool>>> UpdateUser([FromBody] UserDto userDto)
    {
        var userId = _userService.GetUserId();
        var response = await _userService.UpdateUser(userDto, userId);

        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);
    }

    [HttpPost("rateUser")]
    [Authorize]
    public async Task<ActionResult<BaseResponse<bool>>> RateUser([FromBody] int rate, string userEmail)
    {
        var response = await _userService.RateUser(rate, userEmail);

        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);
    }
}

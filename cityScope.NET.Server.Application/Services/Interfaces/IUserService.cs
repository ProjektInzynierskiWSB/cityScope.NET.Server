using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<BaseResponse<int>> Register(UserRegisterDto userDto, string password);
        Task<BaseResponse<string>> Login(UserLoginDto user);
        int GetUserId();
        string GetUserEmail();
    }
}

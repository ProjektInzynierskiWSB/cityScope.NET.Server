using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Helpers;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.Application.Validators;
using cityScope.NET.Server.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        public UserService(IUserRepository userRepository, IConfiguration configuration, IHttpContextAccessor contextAccessor)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _contextAccessor = contextAccessor;
        }
        public async Task<BaseResponse<bool>> RateUser(int rate, string userEmail)
        {
            BaseResponse<bool> response = new();

            if (rate < 1 || rate > 5)
            {
                response.Success = false;
                response.Message = "Rate is not valid. It should be between 1 and 5.";
                response.Data = false;
                return response;
            }

            var user = await _userRepository.GetUserByEmail(userEmail);
            if (user != null)
            {
                var newRate = (user.Rate + rate) / (user.CountOfAllRates + 1);
                user.CountOfAllRates += 1;
                user.Rate = newRate;
                await _userRepository.UpdateAsync(user);
                response.Success = true;
                response.Data = true;
                return response;
            }
            response.Success = false;
            response.Data = false;
            response.Message = (user == null) ? "user not found" : string.Empty;

            return response;
        }
        public async Task<BaseResponse<bool>> UpdateUser(UserDto userDto, int userId)
        {
            BaseResponse<bool> response = new();
            UserEditValidator validator = new();
            var validatorResult = await validator.ValidateAsync(userDto); 
            var user = await _userRepository.GetByIdAsync(userId);
            if (user != null && validatorResult.IsValid)
            {
                user.UserDescription = userDto.Description;
                await _userRepository.UpdateAsync(user);
                response.Success = true;
                response.Data = true;
                return response;
            }

            response.Success = false;
            response.Data = false;
            response.Message = (user == null) ? "user not found" : string.Empty;
            response.Message = string.Join(", ", validatorResult.Errors);

            return response;
        }

        public async Task<BaseResponse<int>> Register(UserRegisterDto userDto, string password)
        {
            UserRegisterValidator validator = new();
            
            var validadorResult = await validator.ValidateAsync(userDto);
            if (!validadorResult.IsValid)
            {
                return new BaseResponse<int>() { Success = false, Message = string.Join(", ", validadorResult.Errors) };
            }
            if (await _userRepository.UserExist(userDto.Email))
            {
                return new BaseResponse<int>() { Success = false, Message = "User Exist" };
            }

            PasswordHasher.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            //CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            User user = new();
            user.Email = userDto.Email;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.NickName = userDto.NickName;

            var result =  await _userRepository.AddAsync(user);

            return new BaseResponse<int>() { Data = result.Id, Message = "User register sucessful" };
        }

        public async Task<BaseResponse<LoginResponseDto>> Login(UserLoginDto userDto)
        {
            BaseResponse<LoginResponseDto> response = new();
            UserLoginValidator validator = new();
            var validadorResult = await validator.ValidateAsync(userDto);

            if (!validadorResult.IsValid)
            {
                return new BaseResponse<LoginResponseDto>() { Success = false, Message = string.Join(", ", validadorResult.Errors) };
            }

            var user = await _userRepository.GetUserByEmail(userDto.Email);
            if (user == null)
            {
                return new BaseResponse<LoginResponseDto>() { Success = false, Message = "User not exist or wrong password" };
            }
            else if(!PasswordHasher.VerifyPasswordHash(userDto.Password, user.PasswordHash, user.PasswordSalt)) 
            {
                return new BaseResponse<LoginResponseDto>() { Success = false, Message = "User not exist or wrong password" };
            }
            else
            {
                response.Data = new LoginResponseDto();
                response.Data.Token = CreateToken(user);
                response.Data.UserName = user.NickName;
            }
            return response;
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email)
            };

            var key = new SymmetricSecurityKey(
                System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddDays(1), signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;                  
        }

        public int GetUserId() => int.Parse(_contextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier).Value);

        public string GetUserEmail() => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
    }
}

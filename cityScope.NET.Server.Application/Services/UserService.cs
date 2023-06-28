using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.Application.Validators;
using cityScope.NET.Server.Domain.Entities;
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
        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
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
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            User user = new();
            user.Email = userDto.Email;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            var result =  await _userRepository.AddAsync(user);

            return new BaseResponse<int>() { Data = result.Id, Message = "User register sucessful" };
        }

        public async Task<BaseResponse<string>> Login(UserLoginDto userDto)
        {
            BaseResponse<string> response = new();
            UserLoginValidator validator = new();
            var validadorResult = await validator.ValidateAsync(userDto);

            if (!validadorResult.IsValid)
            {
                return new BaseResponse<string>() { Success = false, Message = string.Join(", ", validadorResult.Errors) };
            }

            var user = await _userRepository.GetUserByEmail(userDto.Email);
            if (user == null)
            {
                return new BaseResponse<string>() { Success = false, Message = "User not exist or wrong password" };
            }
            else if(!VerifyPasswordHash(userDto.Password, user.PasswordHash, user.PasswordSalt)) 
            {
                return new BaseResponse<string>() { Success = false, Message = "User not exist or wrong password" };
            }
            else
            {
                response.Data = CreateToken(user);
            }
            return response;
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash =
                    hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
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
    }
}

using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
using cityScope.NET.Server.UnitTest.Mocks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.UnitTest.UserTests
{
    public class RegisterUserTests
    {
        private readonly Mock<IUserRepository> _mockRepository;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;

        public RegisterUserTests()
        {
            _mockRepository = RepositoryMocks.GetUserRepository();
            _configuration = TestHelpers.GetConfigurationRoot();
            _contextAccessor = TestHelpers.MockHttpContextAccessor();
        }

        [Fact]
        public async Task ValidUser_RegisterUser()
        {
            var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);
            var allUsersBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            UserRegisterDto userRegisterDto = new()
            {
                Email = "example4@example.com",
                NickName = "NickName",
                Password = "Haslo123",
                ConfirmPassword = "Haslo123"
            };

            var response = await handler.Register(userRegisterDto, userRegisterDto.Password);
            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            allAfter.Count.ShouldBe(allUsersBeforeCount + 1);
        }

        [Fact]
        public async Task NotValid_NotRegister_EmailIsNotEmail()
        {
            var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);
            var allUsersBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            UserRegisterDto userRegisterDto = new()
            {
                Email = "example",
                NickName = "NickName",
                Password = "Haslo123",
                ConfirmPassword = "Haslo123"
            };

            var response = await handler.Register(userRegisterDto, userRegisterDto.Password);
            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            allAfter.Count.ShouldBe(allUsersBeforeCount);
        }

        [Fact]
        public async Task NotValid_NotRegister_PasswordNotMatch()
        {
            var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);
            var allUsersBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            UserRegisterDto userRegisterDto = new()
            {
                Email = "example@example.com",
                NickName = "NickName",
                Password = "Haslo1231",
                ConfirmPassword = "Haslo123"
            };

            var response = await handler.Register(userRegisterDto, userRegisterDto.Password);
            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            allAfter.Count.ShouldBe(allUsersBeforeCount);
        }

        [Fact]
        public async Task NotValid_NotRegister_PasswordTooShort()
        {
            var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);
            var allUsersBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            UserRegisterDto userRegisterDto = new()
            {
                Email = "example@example.com",
                NickName = "NickName",
                Password = "Haslo",
                ConfirmPassword = "Haslo"
            };

            var response = await handler.Register(userRegisterDto, userRegisterDto.Password);
            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            allAfter.Count.ShouldBe(allUsersBeforeCount);
        }

        [Fact]
        public async Task NotValid_NotRegister_MissingNickName()
        {
            var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);
            var allUsersBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            UserRegisterDto userRegisterDto = new()
            {
                Email = "example@example.com",
                Password = "Haslo",
                ConfirmPassword = "Haslo"
            };

            var response = await handler.Register(userRegisterDto, userRegisterDto.Password);
            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            allAfter.Count.ShouldBe(allUsersBeforeCount);
        }
    }
}

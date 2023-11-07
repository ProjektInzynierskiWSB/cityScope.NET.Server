using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
using cityScope.NET.Server.UnitTest.Mocks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;
using Shouldly;

namespace cityScope.NET.Server.UnitTest.UserTests;

public class UpdateUserTest
{
    private readonly Mock<IUserRepository> _mockRepository;
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _contextAccessor;

    public UpdateUserTest()
    {
        _mockRepository = RepositoryMocks.GetUserRepository();
        _configuration = TestHelpers.GetConfigurationRoot();
        _contextAccessor = TestHelpers.MockHttpContextAccessor();
    }

    [Fact]
    public async Task ValidUser_UpdateUser()
    {
        var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);
        var allUserBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        UserDto userDto = new()
        {
            Description = new string('*', 101)
        };

        var response = await handler.UpdateUser(userDto, 1);
        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(true);
        response.Data.ShouldBe(true);
        allAfter.Count.ShouldBe(allUserBeforeCount);
    }

    [Fact]
    public async Task NotValidUser_ToLongDescription_UpdateUser()
    {
        var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);
        var allUserBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        UserDto userDto = new()
        {
            Description = new string('*', 1001)
        };

        var response = await handler.UpdateUser(userDto, 1);
        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        response.Data.ShouldBe(false);
        allAfter.Count.ShouldBe(allUserBeforeCount);
    }
}

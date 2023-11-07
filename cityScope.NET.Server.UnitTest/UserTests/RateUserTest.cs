using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
using cityScope.NET.Server.UnitTest.Mocks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;
using Shouldly;

namespace cityScope.NET.Server.UnitTest.UserTests;

public class RateUserTest
{
    private readonly Mock<IUserRepository> _mockRepository;
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _contextAccessor;

    public RateUserTest()
    {
        _mockRepository = RepositoryMocks.GetUserRepository();
        _configuration = TestHelpers.GetConfigurationRoot();
        _contextAccessor = TestHelpers.MockHttpContextAccessor();
    }

    [Fact]
    public async Task ValidRateUser_UpdateRate()
    {
        var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);

        var userBefore = await _mockRepository.Object.GetUserByEmail("example@string.com");
        int userBeforeCount = userBefore.CountOfAllRates;
        var response = await handler.RateUser(5, "example@string.com");
        var userAfter = await _mockRepository.Object.GetUserByEmail("example@string.com");

        response.Success.ShouldBe(true);
        response.Data.ShouldBe(true);
        userAfter.CountOfAllRates.ShouldBe(userBeforeCount + 1);
    }

    [Fact]
    public async Task NotValidRateUser_ValueAbove5_NotUpdateRate()
    {
        var handler = new UserService(_mockRepository.Object, _configuration, _contextAccessor);

        var userBefore = await _mockRepository.Object.GetUserByEmail("example@string.com");
        int userBeforeCount = userBefore.CountOfAllRates;
        var response = await handler.RateUser(6, "example@string.com");
        var userAfter = await _mockRepository.Object.GetUserByEmail("example@string.com");

        response.Success.ShouldBe(false);
        response.Data.ShouldBe(false);
        userAfter.CountOfAllRates.ShouldBe(userBeforeCount);
    }

}

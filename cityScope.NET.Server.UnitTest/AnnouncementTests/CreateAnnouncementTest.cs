using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.UnitTest.Mocks;
using Moq;
using Shouldly;

namespace cityScope.NET.Server.UnitTest.AnnouncementTests;

public class CreateAnnouncementTest
{
    private readonly Mock<IAnnouncementRepository> _mockRepository;
    private readonly Mock<IUserService> _mockUserService;
    private readonly Mock<IPhotosService> _photosService;
    private readonly Mock<IMainCategoryService> _maintainCategoryService;

    public CreateAnnouncementTest()
    {
        _mockRepository = RepositoryMocks.GetAnnouncementRepository();
        _mockUserService = RepositoryMocks.GetUserService();
        _photosService = RepositoryMocks.GetPhotosService();
        _maintainCategoryService = RepositoryMocks.GetMainCategoryService();
    }

    [Fact]
    public async Task ValidAnnouncement_AddedToRepo()
    {
        var handler = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _photosService.Object, _maintainCategoryService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        AddAnnouncementDto announcementDto = new()
        {
            Title = "Testvalid",
            Description = "TestValid",
            Price = 11.99m,
            MainCategoryId = 1
        };

        var response = await handler.AddAnnouncement(announcementDto);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(true);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount + 1);
    }

    [Fact]
    public async Task Not_ValidAnnouncement_TooLongTitle_101_Characters_NotAddedToRepo()
    {
        var handler = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _photosService.Object, _maintainCategoryService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

        AddAnnouncementDto announcementDto = new()
        {
            Title = new string('*', 101),
            Description = "Test",
            Price = 11.99m,
            MainCategoryId = 1
        };

        var response = await handler.AddAnnouncement(announcementDto);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }

    [Fact]
    public async Task Not_ValidAnnouncement_TooLongDescription_1001_Characters_NotAddedToRepo()
    {
        var handler = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _photosService.Object, _maintainCategoryService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

        AddAnnouncementDto announcementDto = new()
        {
            Title = new string('*', 1001),
            Description = "Test",
            Price = 11.99m,
            MainCategoryId = 1
        };

        var response = await handler.AddAnnouncement(announcementDto);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }

    [Fact]
    public async Task Not_ValidAnnouncement_PriceNotValid_NotAddedToRepo()
    {
        var handler = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _photosService.Object, _maintainCategoryService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

        AddAnnouncementDto announcementDto = new()
        {
            Title = new string('*', 1001),
            Description = "Test",
            Price = 11.9999m,
            MainCategoryId = 1
        };

        var response = await handler.AddAnnouncement(announcementDto);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }

    [Fact]
    public async Task Not_ValidAnnouncement_CategoryNotValid_NotAddedToRepo()
    {
        var handler = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _photosService.Object, _maintainCategoryService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

        AddAnnouncementDto announcementDto = new()
        {
            Title = new string('*', 1001),
            Description = "Test",
            Price = 11.9999m,
            MainCategoryId = 131
        };

        var response = await handler.AddAnnouncement(announcementDto);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }
}

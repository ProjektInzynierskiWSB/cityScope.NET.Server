using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.UnitTest.Mocks;
using Moq;
using Shouldly;

namespace cityScope.NET.Server.UnitTest.AnnouncementTests;

public class UpdateAnnouncementTest
{
    private readonly Mock<IAnnouncementRepository> _mockRepository;
    private readonly Mock<IUserService> _mockUserService;
    private readonly Mock<IPhotosService> _mockPhotosService;
    private readonly Mock<IMainCategoryService> _mockMainCategoriesService;

    public UpdateAnnouncementTest()
    {
        _mockRepository = RepositoryMocks.GetAnnouncementRepository();
        _mockUserService = RepositoryMocks.GetUserService();
        _mockPhotosService = RepositoryMocks.GetPhotosService();
        _mockMainCategoriesService = RepositoryMocks.GetMainCategoryService();
    }

    [Fact]
    public async Task Valid_UpdateAnnouncement_UpdateInRepo()
    {
        var hanlder = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _mockPhotosService.Object, _mockMainCategoriesService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        UpdateAnnouncementDto announcementDto = new()
        {
            Title = "Testvalid",
            Description = "TestValid",
            Price = 11.99m
        };

        var response = await hanlder.UpdateAnnouncement(announcementDto, 1);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(true);
        response.Data.ShouldBe(true);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }

    [Fact]
    public async Task Not_Valid_UpdateAnnouncementTooLongTitle_101_NotUpdateInRepo()
    {
        var hanlder = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _mockPhotosService.Object, _mockMainCategoriesService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        UpdateAnnouncementDto announcementDto = new()
        {
            Title = new string('*', 101),
            Description = "TestValid",
            Price = 11.99m
        };

        var response = await hanlder.UpdateAnnouncement(announcementDto, 1);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        response.Data.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }

    [Fact]
    public async Task Not_Valid_UpdateAnnouncementTooLongDescription_1001_NotUpdateInRepo()
    {
        var hanlder = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _mockPhotosService.Object, _mockMainCategoriesService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        UpdateAnnouncementDto announcementDto = new()
        {
            Title = "TestValid",
            Description = new string('*', 1001),
            Price = 11.99m
        };

        var response = await hanlder.UpdateAnnouncement(announcementDto, 1);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        response.Data.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }

    [Fact]
    public async Task Not_Valid_UpdateAnnouncementPriceNotValid_NotUpdateInRepo()
    {
        var hanlder = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _mockPhotosService.Object, _mockMainCategoriesService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        UpdateAnnouncementDto announcementDto = new()
        {
            Title = "TestValid",
            Description = "TestValid",
            Price = 11.9999m
        };

        var response = await hanlder.UpdateAnnouncement(announcementDto, 1);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        response.Data.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }

    [Fact]
    public async Task NotValid_UpdateAnnouncemet_DiffrentUserId_NotUpdateInRepo()
    {
        var hanlder = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _mockPhotosService.Object, _mockMainCategoriesService.Object);

        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
        UpdateAnnouncementDto announcementDto = new()
        {
            Title = "TestValid",
            Description = "TestValid",
            Price = 11.99m
        };

        var response = await hanlder.UpdateAnnouncement(announcementDto, 6);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        response.Data.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }
}

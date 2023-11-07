using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.UnitTest.Mocks;
using Moq;
using Shouldly;

namespace cityScope.NET.Server.UnitTest.AnnouncementTests;

public class DeleteAnnouncementTest
{
    private readonly Mock<IAnnouncementRepository> _mockRepository;
    private readonly Mock<IUserService> _mockUserService;
    private readonly Mock<IPhotosService> _mockPhotosService;
    private readonly Mock<IMainCategoryService> _mockMainCategoryService;

    public DeleteAnnouncementTest()
    {
        _mockRepository = RepositoryMocks.GetAnnouncementRepository();
        _mockUserService = RepositoryMocks.GetUserService();
        _mockPhotosService = RepositoryMocks.GetPhotosService();
        _mockMainCategoryService = RepositoryMocks.GetMainCategoryService();
    }

    [Fact]
    public async Task ValidAnnouncement_DeletedFromRepo()
    {
        var handler = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _mockPhotosService.Object, _mockMainCategoryService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

        var response = await handler.DeleteAnnouncement(1);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(true);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount - 1);
    }

    [Fact]
    public async Task NotValidAnnouncement_DiffrentUserId_NotDeletedFromRepo()
    {
        var handler = new AnnouncementService(_mockRepository.Object, _mockUserService.Object, _mockPhotosService.Object, _mockMainCategoryService.Object);
        var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

        var response = await handler.DeleteAnnouncement(6);

        var allAfter = await _mockRepository.Object.GetAllAsync();

        response.Success.ShouldBe(false);
        allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
    }
}

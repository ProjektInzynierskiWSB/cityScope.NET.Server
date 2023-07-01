using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.UnitTest.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.UnitTest.AnnouncementTests
{
    public class DeleteAnnouncementTest
    {
        private readonly Mock<IAnnouncementRepository> _mockRepository;
        private readonly Mock<IUserService> _mockUserService;

        public DeleteAnnouncementTest()
        {
            _mockRepository = RepositoryMocks.GetAnnouncementRepository();
            _mockUserService = RepositoryMocks.GetUserService();
        }

        [Fact]
        public async Task ValidAnnouncement_DeletedFromRepo()
        {
            var hanlder = new AnnouncementService(_mockRepository.Object, _mockUserService.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

            var response = await hanlder.DeleteAnnouncement(1);

            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            allAfter.Count.ShouldBe(allAnnouncementBeforeCount - 1);
        }

        [Fact]
        public async Task NotValidAnnouncement_DiffrentUserId_NotDeletedFromRepo()
        {
            var hanlder = new AnnouncementService(_mockRepository.Object, _mockUserService.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

            var response = await hanlder.DeleteAnnouncement(6);

            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
        }
    }
}

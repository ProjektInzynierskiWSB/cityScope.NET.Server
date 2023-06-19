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
    public class CreateAnnouncementTest
    {
        private readonly Mock<IAnnouncementRepository> _mockRepository;

        public CreateAnnouncementTest()
        {
            _mockRepository = RepositoryMocks.GetAnnouncementRepository();
        }

        [Fact]
        public async Task ValidAnnouncement_AddedToRepo()
        {
            var hanlder = new AnnouncementService(_mockRepository.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            AnnouncementDto announcementDto = new()
            {
                Title = "Testvalid",
                Description = "TestValid",
                Price = 11.99m
            };

            var response = await hanlder.AddAnnouncement(announcementDto);

            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            allAfter.Count.ShouldBe(allAnnouncementBeforeCount + 1);
            response.Data.ShouldBeOfType<int>();
        }

        [Fact]
        public async Task Not_ValidAnnouncement_TooLongTitle_101_Characters_NotAddedToRepo()
        {
            var hanlder = new AnnouncementService(_mockRepository.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();

            AnnouncementDto announcementDto = new()
            {
                Title = new string('*', 101),
                Description = "Test",
                Price = 11.99m
            };

            var response = await hanlder.AddAnnouncement(announcementDto);

            var allAfter = await _mockRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            allAfter.Count.ShouldBe(allAnnouncementBeforeCount);
        }
    }
}

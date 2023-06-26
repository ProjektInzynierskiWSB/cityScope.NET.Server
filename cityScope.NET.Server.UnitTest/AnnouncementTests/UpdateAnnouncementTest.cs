using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Services;
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
    public class UpdateAnnouncementTest
    {
        private readonly Mock<IAnnouncementRepository> _mockRepository;

        public UpdateAnnouncementTest()
        {
            _mockRepository = RepositoryMocks.GetAnnouncementRepository();
        }

        [Fact]
        public async Task Valid_UpdateAnnouncement_UpdateInRepo()
        {
            var hanlder = new AnnouncementService(_mockRepository.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            AnnouncementDto announcementDto = new()
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
            var hanlder = new AnnouncementService(_mockRepository.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            AnnouncementDto announcementDto = new()
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
            var hanlder = new AnnouncementService(_mockRepository.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            AnnouncementDto announcementDto = new()
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
            var hanlder = new AnnouncementService(_mockRepository.Object);
            var allAnnouncementBeforeCount = (await _mockRepository.Object.GetAllAsync()).Count();
            AnnouncementDto announcementDto = new()
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
    }
}

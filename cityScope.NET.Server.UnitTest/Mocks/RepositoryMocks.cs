using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Moq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cityScope.NET.Server.UnitTest.Mocks;

public class RepositoryMocks
{
    public static Mock<IMainCategoryService> GetMainCategoryService()
    {
        var mockMainCategoryService = new Mock<IMainCategoryService>();
        var mainCategories = GetMainCategories();
        var categoriesListResponse = new BaseResponse<List<MainCategoryDto>>();
        var list = new List<MainCategoryDto>();
        mainCategories.ForEach(c =>
        {
            MainCategoryDto dto = new()
            {
                Id = c.Id,
                Name = c.Name
            };
            list.Add(dto);
        });
        categoriesListResponse.Data = list;

        mockMainCategoryService.Setup(repo => repo.GetAllCategories()).ReturnsAsync(categoriesListResponse);

       mockMainCategoryService.Setup(repo => repo.IsIdExist(It.IsAny<int>())).ReturnsAsync(
            (int id) =>
            {
                var category = mainCategories.FirstOrDefault(c => c.Id == id);
                if (category != null)
                {
                    return new BaseResponse<bool> { Data = true, Success = true };
                }
                return new BaseResponse<bool> { Data = false, Success = false };
            });
        return mockMainCategoryService;
    }
    public static Mock<IPhotosService> GetPhotosService()
    {
        var mockPhotosService = new Mock<IPhotosService>();
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Helpers\Photo\table.jpg");

        // Tworzenie przykładowego obiektu IFormFile na podstawie pliku
        var fileBytes = File.ReadAllBytes(filePath);
        var fileStream = new MemoryStream(fileBytes);
        IFormFile file = new FormFile(fileStream, 0, fileBytes.Length, "table.jpg", "table.jpg");

        mockPhotosService.Setup(repo => repo.UploadImage(file));

        return mockPhotosService;
    }
    public static Mock<IUserService> GetUserService()
    {
        var mockUserService = new Mock<IUserService>();

        mockUserService.Setup(repo => repo.GetUserId()).Returns(1);
        mockUserService.Setup(repo => repo.GetUserEmail()).Returns("example@string.com");

        return mockUserService;
    }
    public static Mock<IAnnouncementRepository> GetAnnouncementRepository()
    {
        var announcements = GetAnnouncements();
        var mockAnnouncementRepository = new Mock<IAnnouncementRepository>();

        mockAnnouncementRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(announcements);

        mockAnnouncementRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(
            (int id) =>
            {
                var announcement = announcements.FirstOrDefault(a => a.Id == id);
                return announcement;
            });

        mockAnnouncementRepository.Setup(repo => repo.AddAsync(It.IsAny<Announcement>())).ReturnsAsync(
            (Announcement announcement) =>
            {
                announcements.Add(announcement);
                return announcement;
            });

        mockAnnouncementRepository.Setup(repo => repo.DeleteAsync(It.IsAny<Announcement>())).Callback<Announcement>((entity) => announcements.Remove(entity));

        mockAnnouncementRepository.Setup(repo => repo.UpdateAsync(It.IsAny<Announcement>())).Callback<Announcement>((entity) =>
        {
            //announcements.Remove(entity);
            var index = announcements.FindIndex(a => a.Id == entity.Id);
            if (index >= 0)
            {
                announcements.RemoveAt(index);
                announcements.Add(entity);
            }
            //announcements.Add(entity);
        });

        return mockAnnouncementRepository;
    }

    public static Mock<IUserRepository> GetUserRepository()
    {
        var users = GetUsers();
        var mockUserRepository = new Mock<IUserRepository>();

        mockUserRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(users);

        mockUserRepository.Setup(repo => repo.AddAsync(It.IsAny<User>())).ReturnsAsync(
            (User user) =>
            {
                users.Add(user);
                return user;
            });

        mockUserRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(
            (int id) =>
            {
                var user = users.FirstOrDefault(a => a.Id == id);
                return user;
            });

        mockUserRepository.Setup(repo => repo.UserExist(It.IsAny<string>())).ReturnsAsync(
            (string email) =>
            {
                var exist = users.Any(user => user.Email.ToLower().Equals(email.ToLower()));
                return exist;
            });

        mockUserRepository.Setup(repo => repo.GetUserByEmail(It.IsAny<string>())).ReturnsAsync(
            (string email) =>
            {
                var user = users.FirstOrDefault(user => user.Email.ToLower().Equals(email.ToLower()));
                return user;
            });
        return mockUserRepository;
    }

    private static List<User> GetUsers()
    {
        var list = new List<User>();
        User u1 = new User()
        {
            Id = 1,
            Email = "example@string.com",
            PasswordHash = new byte[2] { 1, 2 },
            PasswordSalt = new byte[2] { 1, 2 },
            CreatedDate = DateTime.Now,
        };
        User u2 = new User()
        {
            Id = 2,
            Email = "example2@string.com",
            PasswordHash = new byte[2] { 1, 2 },
            PasswordSalt = new byte[2] { 1, 2 },
            CreatedDate = DateTime.Now,
        };
        User u3 = new User()
        {
            Id = 3,
            Email = "example3@string.com",
            PasswordHash = new byte[2] { 1, 2 },
            PasswordSalt = new byte[2] { 1, 2 },
            CreatedDate = DateTime.Now,
        };
        list.Add(u1); list.Add(u2); list.Add(u3);

        return list;
    }

    private static List<MainCategory> GetMainCategories()
    {
        var list = new List<MainCategory>();
        MainCategory c1 = new()
        {
            Id = 1,
            Name = "Cars"
        };
        MainCategory c2 = new()
        {
            Id = 2,
            Name = "Toys"
        };
        MainCategory c3 = new()
        {
            Id = 3,
            Name = "Electronic"
        };
        list.Add(c1); list.Add(c2); list.Add(c3);
        return list;
    }

    private static List<Announcement> GetAnnouncements()
    {
        var list = new List<Announcement>();
        Announcement a1 = new Announcement()
        {
            Id = 1,
            Title = "Lorem ipsum",
            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
            Price = 19.99m,
            CreatedDate = DateTime.Now,
            LastModifiedDate = DateTime.MinValue,
            UserId = 1,
        };

        Announcement a2 = new Announcement()
        {
            Id = 2,
            Title = "New Collection Sale",
            Description = "Discover our new collection of trendy clothes and enjoy special discounts for a limited time.",
            Price = 29.99m,
            CreatedDate = DateTime.Now,
            LastModifiedDate = DateTime.MinValue,
            UserId = 1
        };

        Announcement a3 = new Announcement()
        {
            Id = 3,
            Title = "Summer Vacation Deals",
            Description = "Plan your dream summer vacation with our exclusive deals on hotels, flights, and tours.",
            Price = 1999.99m,
            CreatedDate = DateTime.Now,
            LastModifiedDate = DateTime.MinValue,
            UserId = 1
        };

        Announcement a4 = new Announcement()
        {
            Id = 4,
            Title = "Gourmet Food Festival",
            Description = "Indulge in a gastronomic experience at our annual gourmet food festival. Taste exquisite dishes prepared by renowned chefs.",
            Price = 49.99m,
            CreatedDate = DateTime.Now,
            LastModifiedDate = DateTime.MinValue,
            UserId = 1
        };

        Announcement a5 = new Announcement()
        {
            Id = 5,
            Title = "Fitness Membership Discount",
            Description = "Get fit and save money with our limited-time offer on gym memberships. Achieve your fitness goals with state-of-the-art equipment and professional trainers.",
            Price = 39.99m,
            CreatedDate = DateTime.Now,
            LastModifiedDate = DateTime.MinValue,
            UserId = 1
        };

        Announcement a6 = new()
        {
            Id = 6,
            Title = "Kosiarka",
            Description = "Sprzedam używaną kosiarkę, działa!",
            Price = 100,
            CreatedDate = DateTime.Now,
            LastModifiedDate = DateTime.MinValue,
            UserId = 2
        };
        list.Add(a1);
        list.Add(a2);
        list.Add(a3);
        list.Add(a4);
        list.Add(a5);
        list.Add(a6);
        return list;
    }
}

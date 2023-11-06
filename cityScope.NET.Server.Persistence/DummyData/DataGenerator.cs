using Bogus;
using cityScope.NET.Server.Application.Helpers;
using cityScope.NET.Server.Domain.Entities;

namespace cityScope.NET.Server.Persistence.DummyData
{
    public class DataGenerator
    {
        public List<Announcement> Announcements = new();
        public List<User> Users = new();
        public List<MainCategory> MainCategories = new(); 
        private List<string> PhotoUrls = new()
        {
            "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
            "https://blobinz.blob.core.windows.net/images/table.jpg",
            "https://blobinz.blob.core.windows.net/images/tv.jpg"
        };
        public DataGenerator()
        {
            Seed();
        }
        private void Seed()
        {
            string locale = "pl";
            int id = 1;
            string pass = "string123";
            PasswordHasher.CreatePasswordHash(pass, out byte[] passwordHash, out byte[] passwordSalt);
            var userGenerator = new Faker<User>(locale)
                .RuleFor(u => u.Id, _ => 1)
                .RuleFor(u => u.Email, "example@example.com")
                .RuleFor(u => u.PasswordHash, passwordHash)
                .RuleFor(u => u.PasswordSalt, passwordSalt);
            var listUsers = userGenerator.Generate(1);
            Users.AddRange(listUsers);

            var categoryGenerator = new Faker<MainCategory>(locale)
                .RuleFor(a => a.Id, _ => id++)
                .RuleFor(a => a.Name, f => f.Commerce.Categories(10)[f.Random.Int(1, 9)]);
            var listCategories = categoryGenerator.Generate(10);
            MainCategories.AddRange(listCategories);

            id = 1;
            var annoucementGenerator = new Faker<Announcement>(locale)
                .RuleFor(a => a.Id, _ => id++)
                .RuleFor(a => a.Title, f => f.Commerce.ProductName())
                .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
                .RuleFor(a => a.LastModifiedDate, f => DateTime.Now)
                .RuleFor(a => a.UserId, _ => 1)
                .RuleFor(a => a.Price, f => Math.Round(f.Random.Decimal(10, 10000), 2))
                .RuleFor(a => a.MainCategoryId, f => f.PickRandom(listCategories).Id)
                .RuleFor(a => a.UrlImage, f => f.PickRandom(PhotoUrls));
            var listAnnouncement = annoucementGenerator.Generate(10);
            Announcements.AddRange(listAnnouncement);

        }
    }
}

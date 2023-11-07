using cityScope.NET.Server.Domain.Entities;
using cityScope.NET.Server.Persistence.DummyData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Persistence
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<MainCategory> MainCategory { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.
               ApplyConfigurationsFromAssembly
               (typeof(MyDbContext).Assembly);

            base.OnModelCreating(modelBuilder);

            var dataGenerator = new DataGenerator();

            modelBuilder.Entity<User>()
                .HasData(dataGenerator.Users);

            modelBuilder.Entity<MainCategory>()
                .HasData(dataGenerator.MainCategories);

            modelBuilder.Entity<Announcement>()
                .HasData(dataGenerator.Announcements);
        }
    }
}

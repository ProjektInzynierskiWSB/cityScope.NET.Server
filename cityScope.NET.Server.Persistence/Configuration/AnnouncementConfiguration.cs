using cityScope.NET.Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Persistence.Configuration
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(1000);
            builder.Property(a => a.Price).IsRequired().HasPrecision(10, 2);
        }
    }
}

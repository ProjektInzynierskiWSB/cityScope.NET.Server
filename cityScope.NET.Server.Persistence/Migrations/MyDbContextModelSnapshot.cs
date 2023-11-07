﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cityScope.NET.Server.Persistence;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("cityScope.NET.Server.Domain.Entities.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrlImage")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Announcements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(3050),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(3333),
                            MainCategoryId = 4,
                            Price = 9876.39m,
                            Title = "Handmade Soft Table",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5055),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5132),
                            MainCategoryId = 1,
                            Price = 9395.44m,
                            Title = "Generic Cotton Chair",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5157),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5192),
                            MainCategoryId = 3,
                            Price = 811.27m,
                            Title = "Incredible Concrete Chicken",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5207),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5235),
                            MainCategoryId = 3,
                            Price = 9280.14m,
                            Title = "Generic Granite Chicken",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5250),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5280),
                            MainCategoryId = 6,
                            Price = 7681.32m,
                            Title = "Generic Wooden Computer",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5363),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5393),
                            MainCategoryId = 5,
                            Price = 2049.03m,
                            Title = "Practical Steel Car",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5408),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5437),
                            MainCategoryId = 10,
                            Price = 9403.80m,
                            Title = "Incredible Plastic Bacon",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5451),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5484),
                            MainCategoryId = 10,
                            Price = 8985.97m,
                            Title = "Ergonomic Metal Bike",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5498),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5527),
                            MainCategoryId = 4,
                            Price = 5837.82m,
                            Title = "Fantastic Wooden Keyboard",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5541),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            LastModifiedDate = new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5570),
                            MainCategoryId = 1,
                            Price = 8388.46m,
                            Title = "Tasty Metal Soap",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("cityScope.NET.Server.Domain.Entities.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MainCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Toys"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Outdoors"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Shoes"
                        });
                });

            modelBuilder.Entity("cityScope.NET.Server.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("Uniqueness", "Email");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastTimeLogin")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<bool>("isBlocked")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 6, 13, 28, 11, 707, DateTimeKind.Local).AddTicks(4404),
                            Email = "example@example.com",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastTimeLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = new byte[] { 213, 93, 107, 37, 68, 1, 138, 109, 67, 170, 253, 21, 47, 91, 97, 172, 100, 250, 13, 6, 150, 126, 50, 163, 126, 15, 29, 145, 2, 222, 247, 149, 46, 244, 162, 67, 17, 74, 131, 126, 215, 20, 34, 146, 204, 63, 162, 199, 158, 219, 115, 237, 16, 91, 194, 224, 253, 38, 127, 146, 168, 29, 231, 96 },
                            PasswordSalt = new byte[] { 158, 75, 93, 60, 72, 162, 93, 151, 28, 253, 229, 192, 18, 122, 117, 79, 57, 72, 108, 212, 72, 237, 147, 37, 121, 29, 114, 204, 172, 224, 135, 91, 222, 161, 21, 111, 4, 200, 168, 126, 12, 135, 219, 62, 116, 76, 184, 130, 16, 212, 49, 39, 165, 184, 50, 178, 25, 164, 106, 91, 126, 70, 10, 35, 237, 201, 211, 141, 0, 111, 12, 107, 78, 238, 111, 107, 154, 46, 198, 13, 139, 170, 10, 169, 60, 190, 84, 109, 59, 168, 142, 252, 156, 127, 93, 248, 19, 156, 29, 216, 215, 74, 202, 42, 192, 215, 116, 254, 13, 19, 158, 94, 194, 96, 72, 22, 11, 165, 90, 122, 44, 202, 61, 27, 47, 59, 115, 17 },
                            isBlocked = false
                        });
                });

            modelBuilder.Entity("cityScope.NET.Server.Domain.Entities.Announcement", b =>
                {
                    b.HasOne("cityScope.NET.Server.Domain.Entities.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cityScope.NET.Server.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

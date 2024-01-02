﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cityScope.NET.Server.Persistence;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231129170607_CountOFAllRates")]
    partial class CountOFAllRates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(4565),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(4913),
                            MainCategoryId = 3,
                            Price = 2041.33m,
                            Title = "Refined Rubber Shoes",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(6865),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(6947),
                            MainCategoryId = 7,
                            Price = 9473.44m,
                            Title = "Ergonomic Wooden Soap",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(6974),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7006),
                            MainCategoryId = 6,
                            Price = 7982.97m,
                            Title = "Refined Soft Pizza",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7023),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7114),
                            MainCategoryId = 2,
                            Price = 1684.14m,
                            Title = "Generic Fresh Towels",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7130),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7158),
                            MainCategoryId = 4,
                            Price = 7652.20m,
                            Title = "Tasty Fresh Shoes",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7173),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7203),
                            MainCategoryId = 9,
                            Price = 7552.78m,
                            Title = "Handcrafted Fresh Gloves",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7217),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7246),
                            MainCategoryId = 10,
                            Price = 4521.80m,
                            Title = "Incredible Fresh Sausages",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7260),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7288),
                            MainCategoryId = 2,
                            Price = 9724.73m,
                            Title = "Awesome Plastic Towels",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7302),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7332),
                            MainCategoryId = 5,
                            Price = 6475.77m,
                            Title = "Licensed Cotton Shirt",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7346),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            LastModifiedDate = new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7373),
                            MainCategoryId = 7,
                            Price = 8501.94m,
                            Title = "Awesome Granite Fish",
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
                            Name = "Grocery"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tools"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Industrial"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Home"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Outdoors"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Health"
                        });
                });

            modelBuilder.Entity("cityScope.NET.Server.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountOfAllRates")
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

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("UserDescription")
                        .HasColumnType("longtext");

                    b.Property<bool>("isBlocked")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountOfAllRates = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 18, 6, 7, 353, DateTimeKind.Local).AddTicks(1603),
                            Email = "example@example.com",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastTimeLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = new byte[] { 222, 169, 13, 83, 176, 95, 117, 40, 226, 97, 17, 178, 40, 140, 181, 243, 224, 30, 182, 235, 240, 185, 35, 68, 21, 43, 233, 247, 252, 72, 226, 103, 32, 81, 191, 242, 227, 167, 44, 201, 197, 230, 131, 180, 75, 120, 112, 2, 218, 7, 130, 10, 185, 153, 56, 17, 28, 123, 37, 86, 159, 211, 138, 95 },
                            PasswordSalt = new byte[] { 27, 193, 24, 227, 203, 234, 53, 104, 101, 105, 31, 84, 2, 204, 87, 225, 100, 172, 128, 96, 13, 1, 203, 34, 131, 153, 234, 60, 37, 72, 51, 71, 92, 170, 85, 219, 91, 191, 33, 59, 37, 251, 134, 49, 224, 203, 2, 53, 7, 212, 221, 71, 5, 12, 25, 8, 14, 220, 97, 57, 122, 203, 70, 231, 3, 240, 44, 83, 218, 128, 234, 27, 91, 100, 229, 63, 118, 19, 118, 197, 14, 138, 200, 9, 100, 31, 232, 226, 140, 252, 162, 218, 209, 185, 36, 124, 97, 195, 29, 110, 7, 119, 206, 232, 251, 105, 92, 212, 72, 0, 107, 232, 178, 174, 163, 202, 78, 60, 246, 17, 138, 53, 245, 24, 66, 188, 244, 34 },
                            Rate = 5,
                            UserDescription = "voluptas",
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
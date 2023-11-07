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
    [Migration("20231107162448_addRateAndUserDescription")]
    partial class addRateAndUserDescription
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
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 427, DateTimeKind.Local).AddTicks(9822),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(146),
                            MainCategoryId = 3,
                            Price = 8540.09m,
                            Title = "Sleek Wooden Computer",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(1994),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2073),
                            MainCategoryId = 4,
                            Price = 1178.12m,
                            Title = "Refined Wooden Keyboard",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2100),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2132),
                            MainCategoryId = 4,
                            Price = 7128.87m,
                            Title = "Small Granite Bike",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2148),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2237),
                            MainCategoryId = 7,
                            Price = 399.37m,
                            Title = "Practical Rubber Pizza",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2256),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2288),
                            MainCategoryId = 4,
                            Price = 1059.05m,
                            Title = "Tasty Soft Pants",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2302),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2333),
                            MainCategoryId = 2,
                            Price = 9368.13m,
                            Title = "Gorgeous Concrete Chips",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2347),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2375),
                            MainCategoryId = 8,
                            Price = 1181.44m,
                            Title = "Licensed Steel Keyboard",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/tv.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2389),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2420),
                            MainCategoryId = 9,
                            Price = 733.85m,
                            Title = "Handcrafted Rubber Tuna",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2434),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2464),
                            MainCategoryId = 7,
                            Price = 8973.57m,
                            Title = "Handmade Granite Sausages",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/ksiazka.jpg",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2478),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            LastModifiedDate = new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2507),
                            MainCategoryId = 7,
                            Price = 6384.46m,
                            Title = "Sleek Cotton Chips",
                            UrlImage = "https://blobinz.blob.core.windows.net/images/table.jpg",
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
                            Name = "Movies"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Toys"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Shoes"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Jewelery"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Kids"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Grocery"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Tools"
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
                            CreatedDate = new DateTime(2023, 11, 7, 17, 24, 48, 423, DateTimeKind.Local).AddTicks(7397),
                            Email = "example@example.com",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastTimeLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = new byte[] { 245, 98, 125, 137, 0, 70, 146, 113, 207, 64, 224, 215, 117, 205, 100, 45, 68, 126, 101, 43, 80, 126, 210, 153, 189, 217, 64, 185, 128, 57, 38, 45, 17, 8, 27, 5, 247, 239, 182, 40, 51, 84, 43, 2, 15, 219, 39, 235, 97, 69, 220, 170, 35, 75, 111, 46, 5, 111, 216, 135, 210, 239, 84, 223 },
                            PasswordSalt = new byte[] { 208, 85, 96, 214, 252, 144, 27, 66, 169, 140, 231, 18, 29, 149, 40, 141, 215, 215, 81, 228, 77, 211, 124, 91, 86, 241, 15, 105, 136, 251, 130, 100, 123, 227, 50, 71, 254, 228, 176, 71, 254, 211, 78, 88, 193, 250, 19, 219, 32, 94, 42, 155, 120, 232, 138, 134, 169, 18, 224, 130, 194, 17, 33, 61, 98, 151, 77, 51, 205, 29, 233, 42, 170, 151, 172, 131, 53, 71, 176, 45, 64, 144, 163, 212, 2, 45, 102, 161, 186, 32, 221, 215, 36, 45, 35, 68, 219, 128, 23, 246, 124, 139, 245, 15, 124, 76, 92, 197, 67, 65, 123, 119, 69, 215, 207, 86, 102, 70, 109, 187, 190, 236, 188, 33, 93, 165, 172, 124 },
                            Rate = 1,
                            UserDescription = "cum",
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
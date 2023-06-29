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
    [Migration("20230629100846_editAnnu")]
    partial class editAnnu
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

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Announcements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(2766),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(3045),
                            Price = 4624.77m,
                            Title = "Licensed Concrete Hat",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(4929),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5017),
                            Price = 954.21m,
                            Title = "Intelligent Plastic Ball",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5041),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5074),
                            Price = 1764.57m,
                            Title = "Awesome Wooden Pizza",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5085),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5118),
                            Price = 7306.23m,
                            Title = "Unbranded Frozen Soap",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5129),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5160),
                            Price = 859.59m,
                            Title = "Unbranded Cotton Bike",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5170),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5199),
                            Price = 4822.65m,
                            Title = "Intelligent Steel Bacon",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5209),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5235),
                            Price = 547.72m,
                            Title = "Unbranded Frozen Soap",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5245),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5276),
                            Price = 1305.85m,
                            Title = "Handcrafted Metal Gloves",
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5285),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5353),
                            Price = 8923.44m,
                            Title = "Incredible Soft Shoes",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5363),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            LastModifiedDate = new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5391),
                            Price = 4752.53m,
                            Title = "Refined Cotton Chips",
                            UserId = 1
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
                        .HasColumnType("longtext");

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
                            CreatedDate = new DateTime(2023, 6, 29, 12, 8, 45, 911, DateTimeKind.Local).AddTicks(102),
                            Email = "malwina_debski68@hotmail.com",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastTimeLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = new byte[] { 1, 2 },
                            PasswordSalt = new byte[] { 1, 2 },
                            isBlocked = false
                        });
                });

            modelBuilder.Entity("cityScope.NET.Server.Domain.Entities.Announcement", b =>
                {
                    b.HasOne("cityScope.NET.Server.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

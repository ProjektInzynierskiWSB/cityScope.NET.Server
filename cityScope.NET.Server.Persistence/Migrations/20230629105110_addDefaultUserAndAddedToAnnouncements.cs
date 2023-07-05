using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addDefaultUserAndAddedToAnnouncements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(930), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(1273), 4170.63m, "Handcrafted Rubber Mouse", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3167), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3305), 2704.06m, "Small Soft Bacon", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3328), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3361), 5606.23m, "Small Frozen Computer", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3373), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3404), 6905.93m, "Tasty Frozen Shirt", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3414), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3443), 3099.08m, "Handcrafted Granite Cheese", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3453), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3481), 7810.16m, "Small Metal Pants", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3490), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3522), 9505.44m, "Ergonomic Metal Soap", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3531), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3560), 191.85m, "Intelligent Cotton Chair", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3569), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3599), 4456.99m, "Incredible Fresh Pizza", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3608), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3636), 4696.97m, "Sleek Plastic Towels", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "LastModifiedDate", "LastTimeLogin", "PasswordHash", "PasswordSalt", "isBlocked" },
                values: new object[] { 1, new DateTime(2023, 6, 29, 12, 51, 10, 403, DateTimeKind.Local).AddTicks(45), "example@example.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 89, 230, 85, 104, 118, 145, 154, 123, 80, 103, 230, 243, 218, 252, 86, 52, 69, 200, 129, 211, 245, 133, 40, 22, 120, 78, 30, 215, 162, 242, 243, 161, 35, 130, 15, 65, 96, 30, 151, 180, 13, 6, 190, 206, 104, 115, 21, 236, 127, 87, 15, 225, 214, 138, 52, 14, 166, 50, 193, 237, 153, 7, 31, 62 }, new byte[] { 2, 162, 173, 90, 108, 187, 26, 81, 87, 66, 32, 203, 243, 67, 20, 155, 208, 250, 180, 250, 99, 141, 223, 53, 165, 77, 59, 77, 78, 162, 3, 4, 200, 116, 35, 113, 197, 249, 104, 226, 174, 189, 111, 248, 8, 132, 73, 24, 76, 95, 65, 98, 51, 149, 124, 90, 206, 133, 252, 107, 102, 220, 54, 37, 140, 83, 32, 23, 97, 239, 19, 98, 27, 0, 45, 174, 141, 36, 220, 56, 177, 48, 214, 147, 184, 228, 216, 119, 78, 180, 52, 160, 168, 143, 63, 219, 2, 92, 135, 40, 177, 11, 76, 113, 232, 109, 136, 152, 64, 43, 80, 176, 224, 205, 194, 130, 129, 158, 58, 87, 170, 141, 124, 241, 220, 130, 244, 235 }, false });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_UserId",
                table: "Announcements",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Users_UserId",
                table: "Announcements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_Users_UserId",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_UserId",
                table: "Announcements");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 691, DateTimeKind.Local).AddTicks(9926), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(1546), 7373.92m, "Unbranded Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3009), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3098), 5944.20m, "Handmade Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3117), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3150), 2361.34m, "Awesome Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3160), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3236), 3495.77m, "Refined Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3246), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3275), 8132.09m, "Licensed Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3284), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3313), 4585.90m, "Small Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3321), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3351), 8064.58m, "Handcrafted Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3359), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3390), 3162.46m, "Sleek Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3399), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3428), 2186.78m, "Licensed Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3437), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3464), 6116.19m, "Handcrafted Frozen Cheese" });
        }
    }
}

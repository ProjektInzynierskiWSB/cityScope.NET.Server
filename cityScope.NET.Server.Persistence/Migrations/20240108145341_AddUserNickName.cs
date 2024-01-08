using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserNickName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Users",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(5563), 9, 9616.69m, "Rustic Granite Chicken", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(7930), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8073), 4, 2191.13m, "Small Steel Chicken", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8113), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8166), 5, 1672.71m, "Gorgeous Rubber Shirt", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8196), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8245), 8, 7157.44m, "Incredible Plastic Chicken", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8277), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8338), 1, 725.49m, "Tasty Rubber Cheese", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8358), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8399), 7, 1848.18m, "Generic Metal Cheese", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8420), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8523), 2595.38m, "Unbranded Cotton Bacon", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8542), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8569), 6, 8326.67m, "Intelligent Steel Bacon", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8584), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8609), 6, 8581.02m, "Ergonomic Cotton Chair", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8623), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 1, 8, 15, 53, 41, 563, DateTimeKind.Local).AddTicks(8651), 1, 3492.75m, "Tasty Concrete Computer", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NickName", "PasswordHash", "PasswordSalt", "UserDescription" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 53, 41, 559, DateTimeKind.Local).AddTicks(1482), "Michal_Wojciechowski", new byte[] { 253, 65, 229, 130, 232, 233, 4, 193, 24, 8, 108, 140, 155, 135, 60, 253, 12, 214, 29, 197, 169, 230, 91, 24, 80, 192, 88, 144, 199, 110, 97, 8, 244, 150, 243, 8, 59, 29, 109, 16, 32, 116, 96, 21, 170, 244, 167, 224, 255, 208, 158, 172, 80, 69, 128, 78, 109, 115, 140, 126, 129, 101, 186, 16 }, new byte[] { 85, 7, 128, 245, 143, 146, 61, 107, 250, 125, 128, 155, 8, 18, 91, 96, 37, 113, 108, 216, 110, 166, 103, 61, 0, 130, 15, 56, 161, 233, 205, 68, 24, 250, 238, 71, 217, 72, 143, 150, 59, 88, 206, 7, 160, 149, 147, 61, 203, 28, 25, 214, 3, 184, 80, 250, 88, 208, 207, 85, 152, 144, 165, 183, 3, 82, 27, 168, 92, 136, 42, 96, 5, 61, 64, 90, 151, 224, 29, 246, 76, 98, 153, 72, 147, 46, 147, 255, 96, 8, 175, 3, 217, 215, 84, 24, 190, 204, 146, 11, 80, 186, 181, 157, 51, 79, 73, 227, 69, 9, 235, 122, 238, 34, 253, 230, 154, 111, 165, 200, 159, 88, 29, 226, 252, 15, 111, 127 }, "odio" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(4913), 3, 2041.33m, "Refined Rubber Shoes", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(6865), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(6947), 7, 9473.44m, "Ergonomic Wooden Soap", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(6974), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7006), 6, 7982.97m, "Refined Soft Pizza", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7023), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7114), 2, 1684.14m, "Generic Fresh Towels", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7130), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7158), 4, 7652.20m, "Tasty Fresh Shoes", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7173), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7203), 9, 7552.78m, "Handcrafted Fresh Gloves", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7217), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7246), 4521.80m, "Incredible Fresh Sausages", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7260), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7288), 2, 9724.73m, "Awesome Plastic Towels", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7302), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7332), 5, 6475.77m, "Licensed Cotton Shirt", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7346), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7373), 7, 8501.94m, "Awesome Granite Fish", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Industrial");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserDescription" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 353, DateTimeKind.Local).AddTicks(1603), new byte[] { 222, 169, 13, 83, 176, 95, 117, 40, 226, 97, 17, 178, 40, 140, 181, 243, 224, 30, 182, 235, 240, 185, 35, 68, 21, 43, 233, 247, 252, 72, 226, 103, 32, 81, 191, 242, 227, 167, 44, 201, 197, 230, 131, 180, 75, 120, 112, 2, 218, 7, 130, 10, 185, 153, 56, 17, 28, 123, 37, 86, 159, 211, 138, 95 }, new byte[] { 27, 193, 24, 227, 203, 234, 53, 104, 101, 105, 31, 84, 2, 204, 87, 225, 100, 172, 128, 96, 13, 1, 203, 34, 131, 153, 234, 60, 37, 72, 51, 71, 92, 170, 85, 219, 91, 191, 33, 59, 37, 251, 134, 49, 224, 203, 2, 53, 7, 212, 221, 71, 5, 12, 25, 8, 14, 220, 97, 57, 122, 203, 70, 231, 3, 240, 44, 83, 218, 128, 234, 27, 91, 100, 229, 63, 118, 19, 118, 197, 14, 138, 200, 9, 100, 31, 232, 226, 140, 252, 162, 218, 209, 185, 36, 124, 97, 195, 29, 110, 7, 119, 206, 232, 251, 105, 92, 212, 72, 0, 107, 232, 178, 174, 163, 202, 78, 60, 246, 17, 138, 53, 245, 24, 66, 188, 244, 34 }, "voluptas" });
        }
    }
}

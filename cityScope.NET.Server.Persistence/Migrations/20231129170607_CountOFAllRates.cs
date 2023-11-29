 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CountOFAllRates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountOfAllRates",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(4565), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(4913), 2041.33m, "Refined Rubber Shoes", "https://blobinz.blob.core.windows.net/images/table.jpg" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7130), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7158), 7652.20m, "Tasty Fresh Shoes", "https://blobinz.blob.core.windows.net/images/table.jpg" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7217), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7246), 10, 4521.80m, "Incredible Fresh Sausages", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7260), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7288), 2, 9724.73m, "Awesome Plastic Towels" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7346), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 29, 18, 6, 7, 357, DateTimeKind.Local).AddTicks(7373), 8501.94m, "Awesome Granite Fish", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

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
                columns: new[] { "CountOfAllRates", "CreatedDate", "PasswordHash", "PasswordSalt", "Rate", "UserDescription" },
                values: new object[] { 1, new DateTime(2023, 11, 29, 18, 6, 7, 353, DateTimeKind.Local).AddTicks(1603), new byte[] { 222, 169, 13, 83, 176, 95, 117, 40, 226, 97, 17, 178, 40, 140, 181, 243, 224, 30, 182, 235, 240, 185, 35, 68, 21, 43, 233, 247, 252, 72, 226, 103, 32, 81, 191, 242, 227, 167, 44, 201, 197, 230, 131, 180, 75, 120, 112, 2, 218, 7, 130, 10, 185, 153, 56, 17, 28, 123, 37, 86, 159, 211, 138, 95 }, new byte[] { 27, 193, 24, 227, 203, 234, 53, 104, 101, 105, 31, 84, 2, 204, 87, 225, 100, 172, 128, 96, 13, 1, 203, 34, 131, 153, 234, 60, 37, 72, 51, 71, 92, 170, 85, 219, 91, 191, 33, 59, 37, 251, 134, 49, 224, 203, 2, 53, 7, 212, 221, 71, 5, 12, 25, 8, 14, 220, 97, 57, 122, 203, 70, 231, 3, 240, 44, 83, 218, 128, 234, 27, 91, 100, 229, 63, 118, 19, 118, 197, 14, 138, 200, 9, 100, 31, 232, 226, 140, 252, 162, 218, 209, 185, 36, 124, 97, 195, 29, 110, 7, 119, 206, 232, 251, 105, 92, 212, 72, 0, 107, 232, 178, 174, 163, 202, 78, 60, 246, 17, 138, 53, 245, 24, 66, 188, 244, 34 }, 5, "voluptas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountOfAllRates",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 427, DateTimeKind.Local).AddTicks(9822), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(146), 8540.09m, "Sleek Wooden Computer", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(1994), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2073), 4, 1178.12m, "Refined Wooden Keyboard", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2100), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2132), 4, 7128.87m, "Small Granite Bike", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2148), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2237), 7, 399.37m, "Practical Rubber Pizza", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2256), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2288), 1059.05m, "Tasty Soft Pants", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2302), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2333), 2, 9368.13m, "Gorgeous Concrete Chips", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2347), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2375), 8, 1181.44m, "Licensed Steel Keyboard", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2389), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2420), 9, 733.85m, "Handcrafted Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2434), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2464), 7, 8973.57m, "Handmade Granite Sausages", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2478), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2507), 6384.46m, "Sleek Cotton Chips", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "Rate", "UserDescription" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 423, DateTimeKind.Local).AddTicks(7397), new byte[] { 245, 98, 125, 137, 0, 70, 146, 113, 207, 64, 224, 215, 117, 205, 100, 45, 68, 126, 101, 43, 80, 126, 210, 153, 189, 217, 64, 185, 128, 57, 38, 45, 17, 8, 27, 5, 247, 239, 182, 40, 51, 84, 43, 2, 15, 219, 39, 235, 97, 69, 220, 170, 35, 75, 111, 46, 5, 111, 216, 135, 210, 239, 84, 223 }, new byte[] { 208, 85, 96, 214, 252, 144, 27, 66, 169, 140, 231, 18, 29, 149, 40, 141, 215, 215, 81, 228, 77, 211, 124, 91, 86, 241, 15, 105, 136, 251, 130, 100, 123, 227, 50, 71, 254, 228, 176, 71, 254, 211, 78, 88, 193, 250, 19, 219, 32, 94, 42, 155, 120, 232, 138, 134, 169, 18, 224, 130, 194, 17, 33, 61, 98, 151, 77, 51, 205, 29, 233, 42, 170, 151, 172, 131, 53, 71, 176, 45, 64, 144, 163, 212, 2, 45, 102, 161, 186, 32, 221, 215, 36, 45, 35, 68, 219, 128, 23, 246, 124, 139, 245, 15, 124, 76, 92, 197, 67, 65, 123, 119, 69, 215, 207, 86, 102, 70, 109, 187, 190, 236, 188, 33, 93, 165, 172, 124 }, 1, "cum" });
        }
    }
}

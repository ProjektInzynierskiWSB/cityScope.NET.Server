using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addRateAndUserDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserDescription",
                table: "Users",
                type: "longtext",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 427, DateTimeKind.Local).AddTicks(9822), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(146), 3, 8540.09m, "Sleek Wooden Computer", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(1994), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2073), 4, 1178.12m, "Refined Wooden Keyboard" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2256), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2288), 4, 1059.05m, "Tasty Soft Pants", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2478), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 7, 17, 24, 48, 428, DateTimeKind.Local).AddTicks(2507), 7, 6384.46m, "Sleek Cotton Chips", "https://blobinz.blob.core.windows.net/images/table.jpg" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserDescription",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(3050), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(3333), 4, 9876.39m, "Handmade Soft Table", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5055), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5132), 1, 9395.44m, "Generic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5157), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5192), 3, 811.27m, "Incredible Concrete Chicken", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5207), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5235), 3, 9280.14m, "Generic Granite Chicken", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5250), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5280), 6, 7681.32m, "Generic Wooden Computer", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5363), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5393), 5, 2049.03m, "Practical Steel Car", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5408), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5437), 10, 9403.80m, "Incredible Plastic Bacon", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5451), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5484), 10, 8985.97m, "Ergonomic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5498), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5527), 4, 5837.82m, "Fantastic Wooden Keyboard", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5541), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5570), 1, 8388.46m, "Tasty Metal Soap", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Electronics");

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
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 707, DateTimeKind.Local).AddTicks(4404), new byte[] { 213, 93, 107, 37, 68, 1, 138, 109, 67, 170, 253, 21, 47, 91, 97, 172, 100, 250, 13, 6, 150, 126, 50, 163, 126, 15, 29, 145, 2, 222, 247, 149, 46, 244, 162, 67, 17, 74, 131, 126, 215, 20, 34, 146, 204, 63, 162, 199, 158, 219, 115, 237, 16, 91, 194, 224, 253, 38, 127, 146, 168, 29, 231, 96 }, new byte[] { 158, 75, 93, 60, 72, 162, 93, 151, 28, 253, 229, 192, 18, 122, 117, 79, 57, 72, 108, 212, 72, 237, 147, 37, 121, 29, 114, 204, 172, 224, 135, 91, 222, 161, 21, 111, 4, 200, 168, 126, 12, 135, 219, 62, 116, 76, 184, 130, 16, 212, 49, 39, 165, 184, 50, 178, 25, 164, 106, 91, 126, 70, 10, 35, 237, 201, 211, 141, 0, 111, 12, 107, 78, 238, 111, 107, 154, 46, 198, 13, 139, 170, 10, 169, 60, 190, 84, 109, 59, 168, 142, 252, 156, 127, 93, 248, 19, 156, 29, 216, 215, 74, 202, 42, 192, 215, 116, 254, 13, 19, 158, 94, 194, 96, 72, 22, 11, 165, 90, 122, 44, 202, 61, 27, 47, 59, 115, 17 } });
        }
    }
}

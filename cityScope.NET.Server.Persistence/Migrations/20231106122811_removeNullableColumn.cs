using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class removeNullableColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_MainCategory_MainCategoryId",
                table: "Announcements");

            migrationBuilder.AlterColumn<int>(
                name: "MainCategoryId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5055), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5132), 1, 9395.44m, "Generic Cotton Chair", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5363), new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5393), 5, 2049.03m, "Practical Steel Car" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5451), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5484), 10, 8985.97m, "Ergonomic Metal Bike", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5498), new DateTime(2023, 11, 6, 13, 28, 11, 711, DateTimeKind.Local).AddTicks(5527), 4, 5837.82m, "Fantastic Wooden Keyboard", "https://blobinz.blob.core.windows.net/images/table.jpg" });

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
                keyValue: 3,
                column: "Name",
                value: "Clothing");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_MainCategory_MainCategoryId",
                table: "Announcements",
                column: "MainCategoryId",
                principalTable: "MainCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_MainCategory_MainCategoryId",
                table: "Announcements");

            migrationBuilder.AlterColumn<int>(
                name: "MainCategoryId",
                table: "Announcements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 654, DateTimeKind.Local).AddTicks(7699), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 11, 6, 12, 24, 58, 654, DateTimeKind.Local).AddTicks(8046), 10, 3593.49m, "Small Wooden Gloves", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(588), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(667), 5, 9562.12m, "Awesome Wooden Car", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(701), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(736), 4, 4620.16m, "Ergonomic Concrete Soap", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(754), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(790), 10, 5168.30m, "Intelligent Cotton Pizza", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(806), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(839), 8, 1467.77m, "Licensed Metal Hat", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(856), new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(888), 3, 4743.74m, "Handcrafted Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(904), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(932), 3, 4473.45m, "Intelligent Soft Sausages", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(948), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(976), 1, 3223.27m, "Sleek Granite Soap", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(992), new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(1063), 1, 3635.23m, "Sleek Plastic Soap", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(1080), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(1107), 3, 3014.20m, "Sleek Cotton Bike", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Outdoors");

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
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 650, DateTimeKind.Local).AddTicks(7508), new byte[] { 176, 72, 184, 74, 45, 228, 84, 23, 181, 59, 28, 170, 215, 223, 123, 109, 235, 224, 34, 251, 241, 49, 235, 201, 248, 124, 50, 229, 123, 137, 177, 235, 154, 66, 34, 9, 183, 140, 167, 160, 69, 2, 135, 233, 155, 166, 131, 103, 10, 147, 97, 26, 47, 1, 237, 25, 18, 54, 89, 159, 115, 33, 175, 114 }, new byte[] { 178, 197, 164, 125, 77, 4, 228, 180, 221, 218, 22, 192, 207, 245, 72, 24, 118, 34, 22, 153, 35, 208, 205, 132, 131, 22, 154, 95, 221, 64, 163, 254, 102, 57, 208, 240, 138, 172, 244, 197, 167, 198, 92, 157, 228, 172, 206, 184, 98, 28, 147, 69, 170, 145, 67, 26, 16, 52, 62, 231, 130, 52, 102, 55, 186, 177, 153, 121, 249, 230, 80, 74, 123, 89, 117, 121, 64, 214, 214, 45, 21, 252, 228, 11, 230, 67, 79, 175, 182, 2, 59, 229, 13, 183, 185, 156, 130, 93, 189, 136, 216, 125, 118, 143, 201, 175, 175, 214, 45, 215, 17, 145, 165, 90, 47, 234, 90, 20, 5, 104, 246, 236, 8, 85, 166, 157, 84, 121 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_MainCategory_MainCategoryId",
                table: "Announcements",
                column: "MainCategoryId",
                principalTable: "MainCategory",
                principalColumn: "Id");
        }
    }
}

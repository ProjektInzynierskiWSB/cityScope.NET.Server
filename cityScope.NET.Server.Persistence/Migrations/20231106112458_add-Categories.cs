using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainCategoryId",
                table: "Announcements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MainCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategory", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 654, DateTimeKind.Local).AddTicks(7699), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 11, 6, 12, 24, 58, 654, DateTimeKind.Local).AddTicks(8046), 10, 3593.49m, "Small Wooden Gloves" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(806), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(839), 8, 1467.77m, "Licensed Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(856), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(888), 3, 4743.74m, "Handcrafted Fresh Bike", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(948), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(976), 1, 3223.27m, "Sleek Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(992), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(1063), 1, 3635.23m, "Sleek Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "MainCategoryId", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(1080), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 6, 12, 24, 58, 655, DateTimeKind.Local).AddTicks(1107), 3, 3014.20m, "Sleek Cotton Bike", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.InsertData(
                table: "MainCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Toys" },
                    { 2, "Beauty" },
                    { 3, "Jewelery" },
                    { 4, "Outdoors" },
                    { 5, "Jewelery" },
                    { 6, "Outdoors" },
                    { 7, "Kids" },
                    { 8, "Tools" },
                    { 9, "Sports" },
                    { 10, "Automotive" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 11, 6, 12, 24, 58, 650, DateTimeKind.Local).AddTicks(7508), new byte[] { 176, 72, 184, 74, 45, 228, 84, 23, 181, 59, 28, 170, 215, 223, 123, 109, 235, 224, 34, 251, 241, 49, 235, 201, 248, 124, 50, 229, 123, 137, 177, 235, 154, 66, 34, 9, 183, 140, 167, 160, 69, 2, 135, 233, 155, 166, 131, 103, 10, 147, 97, 26, 47, 1, 237, 25, 18, 54, 89, 159, 115, 33, 175, 114 }, new byte[] { 178, 197, 164, 125, 77, 4, 228, 180, 221, 218, 22, 192, 207, 245, 72, 24, 118, 34, 22, 153, 35, 208, 205, 132, 131, 22, 154, 95, 221, 64, 163, 254, 102, 57, 208, 240, 138, 172, 244, 197, 167, 198, 92, 157, 228, 172, 206, 184, 98, 28, 147, 69, 170, 145, 67, 26, 16, 52, 62, 231, 130, 52, 102, 55, 186, 177, 153, 121, 249, 230, 80, 74, 123, 89, 117, 121, 64, 214, 214, 45, 21, 252, 228, 11, 230, 67, 79, 175, 182, 2, 59, 229, 13, 183, 185, 156, 130, 93, 189, 136, 216, 125, 118, 143, 201, 175, 175, 214, 45, 215, 17, 145, 165, 90, 47, 234, 90, 20, 5, 104, 246, 236, 8, 85, 166, 157, 84, 121 } });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_MainCategoryId",
                table: "Announcements",
                column: "MainCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_MainCategory_MainCategoryId",
                table: "Announcements",
                column: "MainCategoryId",
                principalTable: "MainCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_MainCategory_MainCategoryId",
                table: "Announcements");

            migrationBuilder.DropTable(
                name: "MainCategory");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_MainCategoryId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "MainCategoryId",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 941, DateTimeKind.Local).AddTicks(7597), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 11, 4, 8, 53, 52, 941, DateTimeKind.Local).AddTicks(7970), 4825.57m, "Practical Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(18), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(106), 8593.95m, "Awesome Rubber Ball", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(132), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(171), 9085.80m, "Incredible Plastic Shoes", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(186), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(225), 7555.36m, "Gorgeous Plastic Chips", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(239), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(277), 107.41m, "Handmade Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(291), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(333), 8336.14m, "Practical Granite Tuna", "https://blobinz.blob.core.windows.net/images/table.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(346), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(383), 3314.69m, "Handcrafted Wooden Towels", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(396), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(430), 1620.38m, "Handmade Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(443), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(481), 375.91m, "Fantastic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(494), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(566), 1911.07m, "Awesome Soft Shirt", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 939, DateTimeKind.Local).AddTicks(2312), new byte[] { 92, 185, 58, 174, 119, 219, 211, 1, 16, 169, 45, 153, 235, 94, 154, 131, 60, 146, 197, 47, 45, 88, 138, 111, 200, 238, 77, 182, 54, 105, 18, 117, 26, 165, 37, 80, 237, 245, 191, 159, 61, 51, 63, 36, 207, 243, 140, 72, 85, 83, 103, 213, 154, 219, 161, 4, 130, 38, 233, 10, 219, 227, 27, 149 }, new byte[] { 228, 74, 146, 19, 24, 116, 201, 22, 232, 191, 20, 96, 242, 99, 179, 106, 64, 128, 168, 59, 61, 128, 160, 195, 187, 155, 30, 173, 153, 106, 118, 13, 227, 72, 11, 190, 0, 187, 0, 221, 164, 156, 18, 146, 46, 154, 12, 166, 193, 134, 208, 20, 240, 154, 114, 11, 248, 7, 9, 67, 131, 126, 15, 152, 230, 235, 73, 57, 42, 0, 2, 87, 185, 189, 63, 88, 114, 194, 196, 87, 62, 176, 103, 186, 33, 144, 23, 109, 159, 183, 244, 9, 220, 1, 205, 32, 205, 214, 253, 2, 13, 235, 237, 239, 225, 84, 152, 84, 25, 74, 6, 127, 31, 101, 221, 6, 155, 106, 128, 41, 100, 222, 152, 122, 51, 89, 159, 252 } });
        }
    }
}

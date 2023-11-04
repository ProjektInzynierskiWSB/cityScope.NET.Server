using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addImageUrlToAnnouncement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Announcements",
                type: "longtext",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 941, DateTimeKind.Local).AddTicks(7597), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 11, 4, 8, 53, 52, 941, DateTimeKind.Local).AddTicks(7970), 4825.57m, "Practical Frozen Hat", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(106), 8593.95m, "Awesome Rubber Ball", "https://blobinz.blob.core.windows.net/images/tv.jpg" });

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(239), new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(277), 107.41m, "Handmade Frozen Bike", "https://blobinz.blob.core.windows.net/images/table.jpg" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(396), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(430), 1620.38m, "Handmade Rubber Towels", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(443), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(481), 375.91m, "Fantastic Wooden Mouse", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title", "UrlImage" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 11, 4, 8, 53, 52, 942, DateTimeKind.Local).AddTicks(566), 1911.07m, "Awesome Soft Shirt", "https://blobinz.blob.core.windows.net/images/ksiazka.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 53, 52, 939, DateTimeKind.Local).AddTicks(2312), new byte[] { 92, 185, 58, 174, 119, 219, 211, 1, 16, 169, 45, 153, 235, 94, 154, 131, 60, 146, 197, 47, 45, 88, 138, 111, 200, 238, 77, 182, 54, 105, 18, 117, 26, 165, 37, 80, 237, 245, 191, 159, 61, 51, 63, 36, 207, 243, 140, 72, 85, 83, 103, 213, 154, 219, 161, 4, 130, 38, 233, 10, 219, 227, 27, 149 }, new byte[] { 228, 74, 146, 19, 24, 116, 201, 22, 232, 191, 20, 96, 242, 99, 179, 106, 64, 128, 168, 59, 61, 128, 160, 195, 187, 155, 30, 173, 153, 106, 118, 13, 227, 72, 11, 190, 0, 187, 0, 221, 164, 156, 18, 146, 46, 154, 12, 166, 193, 134, 208, 20, 240, 154, 114, 11, 248, 7, 9, 67, 131, 126, 15, 152, 230, 235, 73, 57, 42, 0, 2, 87, 185, 189, 63, 88, 114, 194, 196, 87, 62, 176, 103, 186, 33, 144, 23, 109, 159, 183, 244, 9, 220, 1, 205, 32, 205, 214, 253, 2, 13, 235, 237, 239, 225, 84, 152, 84, 25, 74, 6, 127, 31, 101, 221, 6, 155, 106, 128, 41, 100, 222, 152, 122, 51, 89, 159, 252 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(1756), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(2091), 6448.94m, "Refined Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(3792), new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(3880), 3526.81m, "Sleek Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(3900), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(3936), 2246.41m, "Unbranded Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(3946), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4044), 3155.01m, "Sleek Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4056), new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4086), 2967.25m, "Sleek Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4096), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4125), 5377.74m, "Handcrafted Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4135), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4164), 660.80m, "Intelligent Metal Car" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4174), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4202), 764.98m, "Ergonomic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4211), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4241), 7186.46m, "Sleek Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4279), 15.70m, "Intelligent Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 466, DateTimeKind.Local).AddTicks(9661), new byte[] { 170, 104, 132, 8, 161, 9, 37, 255, 51, 5, 254, 108, 81, 167, 59, 131, 81, 234, 198, 236, 54, 98, 217, 37, 254, 84, 125, 151, 233, 69, 109, 60, 213, 10, 30, 219, 119, 124, 70, 198, 105, 130, 114, 226, 223, 118, 134, 176, 171, 246, 136, 208, 27, 244, 221, 114, 105, 59, 82, 233, 168, 106, 44, 5 }, new byte[] { 33, 111, 223, 95, 30, 54, 139, 202, 199, 100, 76, 105, 209, 183, 148, 75, 117, 128, 44, 146, 31, 96, 102, 33, 144, 108, 202, 77, 181, 57, 104, 147, 60, 193, 215, 146, 172, 118, 140, 152, 55, 182, 212, 126, 73, 49, 49, 82, 67, 168, 28, 130, 251, 195, 186, 126, 127, 151, 220, 25, 98, 176, 32, 41, 185, 160, 25, 4, 68, 240, 59, 139, 96, 124, 220, 76, 55, 171, 132, 217, 68, 28, 160, 35, 139, 142, 156, 229, 179, 210, 204, 4, 226, 42, 52, 21, 15, 191, 6, 113, 77, 55, 123, 217, 68, 0, 233, 73, 151, 123, 3, 204, 162, 150, 127, 119, 146, 100, 173, 75, 111, 106, 203, 169, 70, 48, 189, 80 } });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editUserTableToUniqueEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(3792), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(3880), 3526.81m, "Sleek Fresh Tuna" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4056), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4086), 2967.25m, "Sleek Cotton Computer" });

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4135), new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4164), 660.80m, "Intelligent Metal Car" });

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
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4250), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 6, 29, 13, 17, 4, 469, DateTimeKind.Local).AddTicks(4279), 15.70m, "Intelligent Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 6, 29, 13, 17, 4, 466, DateTimeKind.Local).AddTicks(9661), new byte[] { 170, 104, 132, 8, 161, 9, 37, 255, 51, 5, 254, 108, 81, 167, 59, 131, 81, 234, 198, 236, 54, 98, 217, 37, 254, 84, 125, 151, 233, 69, 109, 60, 213, 10, 30, 219, 119, 124, 70, 198, 105, 130, 114, 226, 223, 118, 134, 176, 171, 246, 136, 208, 27, 244, 221, 114, 105, 59, 82, 233, 168, 106, 44, 5 }, new byte[] { 33, 111, 223, 95, 30, 54, 139, 202, 199, 100, 76, 105, 209, 183, 148, 75, 117, 128, 44, 146, 31, 96, 102, 33, 144, 108, 202, 77, 181, 57, 104, 147, 60, 193, 215, 146, 172, 118, 140, 152, 55, 182, 212, 126, 73, 49, 49, 82, 67, 168, 28, 130, 251, 195, 186, 126, 127, 151, 220, 25, 98, 176, 32, 41, 185, 160, 25, 4, 68, 240, 59, 139, 96, 124, 220, 76, 55, 171, 132, 217, 68, 28, 160, 35, 139, 142, 156, 229, 179, 210, 204, 4, 226, 42, 52, 21, 15, 191, 6, 113, 77, 55, 123, 217, 68, 0, 233, 73, 151, 123, 3, 204, 162, 150, 127, 119, 146, 100, 173, 75, 111, 106, 203, 169, 70, 48, 189, 80 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(930), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(1273), 4170.63m, "Handcrafted Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3167), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3305), 2704.06m, "Small Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3328), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3361), 5606.23m, "Small Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3373), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3404), 6905.93m, "Tasty Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3414), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3443), 3099.08m, "Handcrafted Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3453), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3481), 7810.16m, "Small Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3522), 9505.44m, "Ergonomic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3531), "The Football Is Good For Training And Recreational Purposes", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3560), 191.85m, "Intelligent Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3569), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3599), 4456.99m, "Incredible Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3608), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 29, 12, 51, 10, 405, DateTimeKind.Local).AddTicks(3636), 4696.97m, "Sleek Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 51, 10, 403, DateTimeKind.Local).AddTicks(45), new byte[] { 89, 230, 85, 104, 118, 145, 154, 123, 80, 103, 230, 243, 218, 252, 86, 52, 69, 200, 129, 211, 245, 133, 40, 22, 120, 78, 30, 215, 162, 242, 243, 161, 35, 130, 15, 65, 96, 30, 151, 180, 13, 6, 190, 206, 104, 115, 21, 236, 127, 87, 15, 225, 214, 138, 52, 14, 166, 50, 193, 237, 153, 7, 31, 62 }, new byte[] { 2, 162, 173, 90, 108, 187, 26, 81, 87, 66, 32, 203, 243, 67, 20, 155, 208, 250, 180, 250, 99, 141, 223, 53, 165, 77, 59, 77, 78, 162, 3, 4, 200, 116, 35, 113, 197, 249, 104, 226, 174, 189, 111, 248, 8, 132, 73, 24, 76, 95, 65, 98, 51, 149, 124, 90, 206, 133, 252, 107, 102, 220, 54, 37, 140, 83, 32, 23, 97, 239, 19, 98, 27, 0, 45, 174, 141, 36, 220, 56, 177, 48, 214, 147, 184, 228, 216, 119, 78, 180, 52, 160, 168, 143, 63, 219, 2, 92, 135, 40, 177, 11, 76, 113, 232, 109, 136, 152, 64, 43, 80, 176, 224, 205, 194, 130, 129, 158, 58, 87, 170, 141, 124, 241, 220, 130, 244, 235 } });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeInAnnouncementEntityEfCoreValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Announcements",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Announcements",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Announcements",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Announcements",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(2363), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(4101), 7252.98m, "Licensed Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5623), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5707), 7253.74m, "Handmade Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5726), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5758), 440.23m, "Practical Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5767), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5796), 9963.43m, "Tasty Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5805), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5879), 1915.08m, "Handmade Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5887), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5917), 1290.84m, "Incredible Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5925), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5955), 5655.50m, "Ergonomic Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5964), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5992), 6163.67m, "Handcrafted Metal Table" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6000), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6028), 7202.43m, "Sleek Soft Table" });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6036), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6062), 9962.86m, "Handcrafted Frozen Sausages" });
        }
    }
}

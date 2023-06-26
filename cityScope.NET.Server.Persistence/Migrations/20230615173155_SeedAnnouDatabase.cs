using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnnouDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(2363), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(4101), 7252.98m, "Licensed Wooden Bike" },
                    { 2, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5623), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5707), 7253.74m, "Handmade Rubber Chair" },
                    { 3, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5726), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5758), 440.23m, "Practical Wooden Computer" },
                    { 4, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5767), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5796), 9963.43m, "Tasty Concrete Bike" },
                    { 5, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5805), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5879), 1915.08m, "Handmade Metal Keyboard" },
                    { 6, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5887), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5917), 1290.84m, "Incredible Fresh Table" },
                    { 7, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5925), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5955), 5655.50m, "Ergonomic Plastic Bacon" },
                    { 8, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5964), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(5992), 6163.67m, "Handcrafted Metal Table" },
                    { 9, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6000), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6028), 7202.43m, "Sleek Soft Table" },
                    { 10, new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6036), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 15, 19, 31, 55, 21, DateTimeKind.Local).AddTicks(6062), 9962.86m, "Handcrafted Frozen Sausages" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

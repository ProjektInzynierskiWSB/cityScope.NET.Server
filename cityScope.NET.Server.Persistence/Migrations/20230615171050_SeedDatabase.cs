using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate", "Price", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 15, 19, 10, 50, 766, DateTimeKind.Local).AddTicks(9325), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3799.87m, "Practical Granite Car" },
                    { 2, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2033), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5007.54m, "Practical Cotton Hat" },
                    { 3, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2131), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8128.13m, "Ergonomic Frozen Salad" },
                    { 4, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2172), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5148.69m, "Rustic Frozen Towels" },
                    { 5, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2207), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1585.14m, "Handmade Concrete Pants" },
                    { 6, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2243), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3962.03m, "Tasty Cotton Pizza" },
                    { 7, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2276), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6633.85m, "Refined Fresh Car" },
                    { 8, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2308), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3559.32m, "Small Rubber Pants" },
                    { 9, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2341), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1848.35m, "Handcrafted Concrete Gloves" },
                    { 10, new DateTime(2023, 6, 15, 19, 10, 50, 767, DateTimeKind.Local).AddTicks(2374), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7980.11m, "Rustic Frozen Bacon" }
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

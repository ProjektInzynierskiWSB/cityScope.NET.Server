using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cityScope.NET.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editAnnu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(2766), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(3045), 4624.77m, "Licensed Concrete Hat", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(4929), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5017), 954.21m, "Intelligent Plastic Ball", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5041), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5074), 1764.57m, "Awesome Wooden Pizza", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5085), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5118), 7306.23m, "Unbranded Frozen Soap", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5129), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5160), 859.59m, "Unbranded Cotton Bike", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5170), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5199), 4822.65m, "Intelligent Steel Bacon", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5209), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5235), 547.72m, "Unbranded Frozen Soap", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5245), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5276), 1305.85m, "Handcrafted Metal Gloves", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5285), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5353), 8923.44m, "Incredible Soft Shoes", 1 });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title", "UserId" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5363), new DateTime(2023, 6, 29, 12, 8, 45, 913, DateTimeKind.Local).AddTicks(5391), 4752.53m, "Refined Cotton Chips", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "LastModifiedDate", "LastTimeLogin", "PasswordHash", "PasswordSalt", "isBlocked" },
                values: new object[] { 1, new DateTime(2023, 6, 29, 12, 8, 45, 911, DateTimeKind.Local).AddTicks(102), "malwina_debski68@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 1, 2 }, new byte[] { 1, 2 }, false });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_UserId",
                table: "Announcements",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Users_UserId",
                table: "Announcements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_Users_UserId",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_UserId",
                table: "Announcements");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Announcements");

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "Price", "Title" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 6, 17, 13, 30, 23, 692, DateTimeKind.Local).AddTicks(3464), 6116.19m, "Handcrafted Frozen Cheese" });
        }
    }
}

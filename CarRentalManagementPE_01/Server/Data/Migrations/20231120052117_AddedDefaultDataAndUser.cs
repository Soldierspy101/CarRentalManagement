using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagementPE_01.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f8b981da-c42b-45a3-a000-1e1fb04a346f", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEADECtXGX6gEEU9vj2kYuxBKWkFjY1xYZ+280a5e2RG6LnsfbrswQzIk7RqYbnth9Q==", null, false, "029dd888-717b-421d-aab5-6fce8ec5d0b9", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4469), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4472), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4473), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4808), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4808), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(4811), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5015), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5018), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5049), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5050), new DateTime(2023, 11, 20, 13, 21, 16, 859, DateTimeKind.Local).AddTicks(5050), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}

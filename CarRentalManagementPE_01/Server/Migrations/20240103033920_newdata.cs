using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagementPE_01.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b048bec3-6bee-4d0b-ac36-f75c78706b06", "AQAAAAIAAYagAAAAEIpuwL3fNxrmTN1FtvJcYI4UgqosNrQzmGX+e2bIiC7s9iPK4vPjUzRCuY8EoZL6yQ==", "d9990b59-9d37-4e83-8982-0edf0556216f" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(8907), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9387), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9390), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9673), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9677), new DateTime(2024, 1, 3, 11, 39, 20, 204, DateTimeKind.Local).AddTicks(9678) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c79409cc-9c33-44ec-a2cf-3c01c6655efa", "AQAAAAIAAYagAAAAEB1qkPe6Ue5IWjy7RVWfWz/pKcYfvdTCDHw3LHI3ko8jJHTjHkTwYB2ADW/nvxVdYQ==", "16f44cc6-1bdd-47c5-9179-49154d4fcfe3" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(4953), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5620), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5625), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 1, 3, 10, 52, 21, 473, DateTimeKind.Local).AddTicks(5628) });
        }
    }
}

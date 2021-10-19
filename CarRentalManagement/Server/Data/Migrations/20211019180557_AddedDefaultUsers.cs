using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "627670fd-6780-4ffb-9f21-73c9b7776085",
                column: "ConcurrencyStamp",
                value: "6c2d28cb-2237-4ecf-b3ac-44845d574091");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "869c20f4-5a21-4f87-acec-aa6fb4c68804",
                column: "ConcurrencyStamp",
                value: "c8e7a7b8-03d7-4637-a2a1-09a578fb2682");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1aadfbb1-5743-4604-8dee-d90c9e0c97a5", 0, "0b15279e-0b4d-4350-bc3c-ef6d7e78f0a4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEGT/DXkm++18B+zZ/prqQ3GNzz9NDNzOBK8C7Xv7ZRxl58KI0oqkalcgG6z8+JJmIA==", null, false, "e9ceaf7a-0deb-42b1-912e-92d80f18e9b0", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 106, DateTimeKind.Local).AddTicks(9720), new DateTime(2021, 10, 19, 19, 5, 57, 109, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 109, DateTimeKind.Local).AddTicks(9137), new DateTime(2021, 10, 19, 19, 5, 57, 109, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(2908), new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(3326), new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7278), new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7666), new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7682), new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7688), new DateTime(2021, 10, 19, 19, 5, 57, 111, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "627670fd-6780-4ffb-9f21-73c9b7776085", "1aadfbb1-5743-4604-8dee-d90c9e0c97a5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "627670fd-6780-4ffb-9f21-73c9b7776085", "1aadfbb1-5743-4604-8dee-d90c9e0c97a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1aadfbb1-5743-4604-8dee-d90c9e0c97a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "627670fd-6780-4ffb-9f21-73c9b7776085",
                column: "ConcurrencyStamp",
                value: "d31314a3-a5d3-43cf-b037-f035083d6899");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "869c20f4-5a21-4f87-acec-aa6fb4c68804",
                column: "ConcurrencyStamp",
                value: "2d4a31bf-cb66-47e2-8945-d92ec85fad8e");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 606, DateTimeKind.Local).AddTicks(5706), new DateTime(2021, 10, 19, 18, 34, 44, 610, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 610, DateTimeKind.Local).AddTicks(6185), new DateTime(2021, 10, 19, 18, 34, 44, 610, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(495), new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(1178), new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(6901), new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(7319), new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(7334), new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(7341), new DateTime(2021, 10, 19, 18, 34, 44, 613, DateTimeKind.Local).AddTicks(7343) });
        }
    }
}

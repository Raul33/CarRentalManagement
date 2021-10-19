using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "627670fd-6780-4ffb-9f21-73c9b7776085", "d31314a3-a5d3-43cf-b037-f035083d6899", "Administrator", "ADMINISTRATOR" },
                    { "869c20f4-5a21-4f87-acec-aa6fb4c68804", "2d4a31bf-cb66-47e2-8945-d92ec85fad8e", "User", "USER" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "627670fd-6780-4ffb-9f21-73c9b7776085");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "869c20f4-5a21-4f87-acec-aa6fb4c68804");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 531, DateTimeKind.Local).AddTicks(9414), new DateTime(2021, 10, 19, 18, 11, 38, 534, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 535, DateTimeKind.Local).AddTicks(78), new DateTime(2021, 10, 19, 18, 11, 38, 535, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4256), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4669), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8461), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8849), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8864), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8871), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8874) });
        }
    }
}

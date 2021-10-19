using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 19, 18, 11, 38, 531, DateTimeKind.Local).AddTicks(9414), new DateTime(2021, 10, 19, 18, 11, 38, 534, DateTimeKind.Local).AddTicks(8961), "Black", "System" },
                    { 2, "System", new DateTime(2021, 10, 19, 18, 11, 38, 535, DateTimeKind.Local).AddTicks(78), new DateTime(2021, 10, 19, 18, 11, 38, 535, DateTimeKind.Local).AddTicks(94), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4256), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4283), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4669), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(4680), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8461), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8478), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8849), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8860), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8864), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8867), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8871), new DateTime(2021, 10, 19, 18, 11, 38, 536, DateTimeKind.Local).AddTicks(8874), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
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
        }
    }
}

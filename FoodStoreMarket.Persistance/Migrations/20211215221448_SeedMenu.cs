using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class SeedMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(4003), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 14, 47, 441, DateTimeKind.Local).AddTicks(2422));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(1413));
        }
    }
}

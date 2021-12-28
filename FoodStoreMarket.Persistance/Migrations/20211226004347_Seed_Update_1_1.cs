using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class Seed_Update_1_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ProductSpecificationId" },
                values: new object[] { new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1720), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ProductSpecificationId" },
                values: new object[] { new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(1728), 2 });

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 43, 46, 477, DateTimeKind.Local).AddTicks(158));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ProductSpecificationId" },
                values: new object[] { new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3095), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ProductSpecificationId" },
                values: new object[] { new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3103), null });

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(1457));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "OpeningClosingSpecificationId" },
                values: new object[] { new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(1588), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 41, 49, 836, DateTimeKind.Local).AddTicks(1457));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "OpeningClosingSpecificationId" },
                values: new object[] { new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4153), null });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4019));
        }
    }
}

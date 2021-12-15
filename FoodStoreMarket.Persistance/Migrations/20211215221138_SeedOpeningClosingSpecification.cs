using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class SeedOpeningClosingSpecification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 11, 37, 732, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 11, 37, 732, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.InsertData(
                table: "OpeningClosingSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 15, 23, 11, 37, 732, DateTimeKind.Local).AddTicks(3862), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 11, 37, 732, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 11, 37, 732, DateTimeKind.Local).AddTicks(3216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 10, 38, 297, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 10, 38, 297, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 10, 38, 297, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 10, 38, 297, DateTimeKind.Local).AddTicks(3779));
        }
    }
}

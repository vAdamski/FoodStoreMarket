using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class SeedRestuarantSpec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RestaurantSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "OpeningClosingSpecificationId", "RestaurantId", "StatusId", "Adres_City", "Adres_Email", "Adres_FlatNumber", "Adres_HouseNumber", "Adres_PhoneNumber", "Adres_PostCode", "Adres_Street" },
                values: new object[] { 1, new DateTime(2021, 12, 15, 23, 8, 58, 608, DateTimeKind.Local).AddTicks(410), null, "Best Kebab in Lodz", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BestKebab", 0, 1, 1, "Lodz", "bestkebab@gmail.com", null, "16", "123456789", "94-042", "Olimpijska" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 8, 58, 608, DateTimeKind.Local).AddTicks(282));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 7, 52, 525, DateTimeKind.Local).AddTicks(5822));
        }
    }
}

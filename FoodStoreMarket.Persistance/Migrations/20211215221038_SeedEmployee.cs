using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class SeedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId", "Adres_City", "Adres_Email", "Adres_FlatNumber", "Adres_HouseNumber", "Adres_PhoneNumber", "Adres_PostCode", "Adres_Street", "PersonName_FirstName", "PersonName_LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 15, 23, 10, 38, 297, DateTimeKind.Local).AddTicks(4117), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "Lodz", "mateusz.nowak@gmail.com", "1", "10", "112233445", "94-042", "Rajdowa", "Mateusz", "Nowak" },
                    { 2, new DateTime(2021, 12, 15, 23, 10, 38, 297, DateTimeKind.Local).AddTicks(4318), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "Lodz", "mariusz.gruszka@gmail.com", "44", "80", "987654321", "94-042", "Retkinska", "Mariusz", "Gruszka" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 8, 58, 608, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 8, 58, 608, DateTimeKind.Local).AddTicks(282));
        }
    }
}

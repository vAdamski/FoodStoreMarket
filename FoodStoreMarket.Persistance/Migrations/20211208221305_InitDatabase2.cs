using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class InitDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Indegriments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OpeningClosingHours",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Indegriments",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1814), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mutton meat", 0m, 1 },
                    { 2, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1821), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chicken meat", 0m, 1 },
                    { 3, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1825), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Salad", 0m, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "ProductId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1788), null, "Kebab w Tortilli", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kebab", 1, 1 },
                    { 2, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1796), null, "Fizzy Drink", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pepsi", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "OpeningClosingSpecificationId", "RestaurantId", "StatusId", "Adres_City", "Adres_Email", "Adres_FlatNumber", "Adres_HouseNumber", "Adres_PhoneNumber", "Adres_PostCode", "Adres_Street" },
                values: new object[] { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(356), null, "Best Kebab in Lodz", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BestKebab", 0, 1, 1, "Lodz", "bestkebab@gmail.com", null, "16", "123456789", "94-042", "Olimpijska" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(229), null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId", "Adres_City", "Adres_Email", "Adres_FlatNumber", "Adres_HouseNumber", "Adres_PhoneNumber", "Adres_PostCode", "Adres_Street", "PersonName_FirstName", "PersonName_LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(507), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "Lodz", "mateusz.nowak@gmail.com", "1", "10", "112233445", "94-042", "Rajdowa", "Mateusz", "Nowak" },
                    { 2, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(685), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "Lodz", "mariusz.gruszka@gmail.com", "44", "80", "987654321", "94-042", "Retkinska", "Mariusz", "Gruszka" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1715), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "OpeningClosingSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(882), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "OpeningClosingHours",
                columns: new[] { "Id", "Created", "CreatedBy", "Day", "Inactivated", "InactivatedBy", "IsOpen", "Modified", "ModifiedBy", "OpeningClosingSpecificationId", "StatusId", "ClosingTime_Hour", "ClosingTime_Minute", "ClosingTime_Secound", "OpeningTime_Hour", "OpeningTime_Minute", "OpeningTime_Secound" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(906), null, "Monday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 2, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1072), null, "Tuesday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 3, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1219), null, "Wednesday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 4, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1393), null, "Thursday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 5, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1536), null, "Friday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "OpeningClosingHours",
                columns: new[] { "Id", "Created", "CreatedBy", "Day", "Inactivated", "InactivatedBy", "IsOpen", "Modified", "ModifiedBy", "OpeningClosingSpecificationId", "StatusId" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1685), null, "Saturday", null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 },
                    { 7, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1692), null, "Sunday", null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "ProductSpecificationId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1734), null, null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 1 },
                    { 2, new DateTime(2021, 12, 8, 23, 3, 24, 221, DateTimeKind.Local).AddTicks(1741), null, null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 1 }
                });
        }
    }
}

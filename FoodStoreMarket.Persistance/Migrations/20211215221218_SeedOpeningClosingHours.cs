using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class SeedOpeningClosingHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "OpeningClosingHours",
                columns: new[] { "Id", "Created", "CreatedBy", "Day", "Inactivated", "InactivatedBy", "IsOpen", "Modified", "ModifiedBy", "OpeningClosingSpecificationId", "StatusId", "ClosingTime_Hour", "ClosingTime_Minute", "ClosingTime_Secound", "OpeningTime_Hour", "OpeningTime_Minute", "OpeningTime_Secound" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2125), null, "Monday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 2, new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2346), null, "Tuesday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 3, new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2484), null, "Wednesday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 4, new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2621), null, "Thursday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 5, new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2790), null, "Friday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "OpeningClosingHours",
                columns: new[] { "Id", "Created", "CreatedBy", "Day", "Inactivated", "InactivatedBy", "IsOpen", "Modified", "ModifiedBy", "OpeningClosingSpecificationId", "StatusId" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2933), null, "Saturday", null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 },
                    { 7, new DateTime(2021, 12, 15, 23, 12, 17, 713, DateTimeKind.Local).AddTicks(2941), null, "Sunday", null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "OpeningClosingSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 23, 11, 37, 732, DateTimeKind.Local).AddTicks(3862));

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
    }
}

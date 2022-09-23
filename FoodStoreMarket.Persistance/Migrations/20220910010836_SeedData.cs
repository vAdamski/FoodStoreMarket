using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSpecifications_ProductSpecificationId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeSpecifications_ProductSpecifications_ProductSpecificationId",
                table: "ProductSizeSpecifications");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ProductSizeSpecifications",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(1992), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantId", "StatusId" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2110), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "RestaurantSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "OpeningClosingSpecificationId", "RestaurantId", "StatusId", "Adres_City", "Adres_Email", "Adres_FlatNumber", "Adres_HouseNumber", "Adres_PhoneNumber", "Adres_PostCode", "Adres_Street" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2127), "ALICESMITH@EMAIL.COM", "Pizzeria na osiedlu", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pizzeria #1", null, 1, 1, "Lodz", "PIZZERIA@GMAIL.COM", "", "1", "123456789", "94-000", "al.Politechniki" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2306), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cheese", 1 },
                    { 2, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2308), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sauce", 1 },
                    { 3, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2310), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pepper", 1 },
                    { 4, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2312), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ham", 1 },
                    { 5, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2313), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mushrooms", 1 },
                    { 6, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2315), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pineapple", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "ProductTypeName", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2221), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pizza", 1 },
                    { 2, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2225), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Drink", 1 },
                    { 3, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2227), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beer", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "ProductSpecificationId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2334), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 2, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2336), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 3, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2338), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 4, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2339), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 5, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2341), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 6, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2343), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 7, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2344), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "ProductId", "ProductTypeId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2362), "ALICESMITH@EMAIL.COM", "", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PIZZA #1", 1, 1, 1 },
                    { 2, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2364), "ALICESMITH@EMAIL.COM", "", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PIZZA #2", 2, 1, 1 },
                    { 3, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2366), "ALICESMITH@EMAIL.COM", "", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PIZZA #3", 3, 1, 1 },
                    { 4, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2368), "ALICESMITH@EMAIL.COM", "", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cola", 4, 1, 1 },
                    { 5, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2370), "ALICESMITH@EMAIL.COM", "", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sprite", 5, 1, 1 },
                    { 6, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2372), "ALICESMITH@EMAIL.COM", "", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Zatecky", 6, 1, 1 },
                    { 7, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2374), "ALICESMITH@EMAIL.COM", "", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lech", 7, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "ProductTypeId", "SizeName", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2247), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Small 26cm", 1 },
                    { 2, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2250), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Medium 32cm", 1 },
                    { 3, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2252), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Big 42cm", 1 },
                    { 4, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2253), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "500ml", 1 },
                    { 5, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2255), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "850ml", 1 },
                    { 6, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2257), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "300ml", 1 },
                    { 7, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2285), "ALICESMITH@EMAIL.COM", null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "500ml", 1 }
                });

            migrationBuilder.InsertData(
                table: "IngredientProductSpecification",
                columns: new[] { "IngredientsId", "ProductSpecificationsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductSizeSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Price", "ProductSpecificationId", "SizeId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2992), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20.0, 1, 1, 1 },
                    { 2, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(2998), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25.0, 1, 2, 1 },
                    { 3, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3000), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30.0, 1, 3, 1 },
                    { 4, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3001), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22.0, 2, 1, 1 },
                    { 5, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3003), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27.0, 2, 2, 1 },
                    { 6, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3004), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33.0, 2, 3, 1 },
                    { 7, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3006), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25.0, 3, 1, 1 },
                    { 8, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3008), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30.0, 3, 2, 1 },
                    { 9, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3009), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35.0, 3, 3, 1 },
                    { 10, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3011), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.0, 4, 4, 1 },
                    { 11, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3012), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9.0, 4, 5, 1 },
                    { 12, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3014), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.0, 5, 4, 1 },
                    { 13, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3016), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8.0, 7, 1, 1 },
                    { 14, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3017), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8.0, 6, 6, 1 },
                    { 15, new DateTime(2022, 9, 10, 3, 8, 36, 601, DateTimeKind.Local).AddTicks(3019), "ALICESMITH@EMAIL.COM", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10.0, 6, 7, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSpecifications_ProductSpecificationId",
                table: "Products",
                column: "ProductSpecificationId",
                principalTable: "ProductSpecifications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeSpecifications_ProductSpecifications_ProductSpecificationId",
                table: "ProductSizeSpecifications",
                column: "ProductSpecificationId",
                principalTable: "ProductSpecifications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSpecifications_ProductSpecificationId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeSpecifications_ProductSpecifications_ProductSpecificationId",
                table: "ProductSizeSpecifications");

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientProductSpecification",
                keyColumns: new[] { "IngredientsId", "ProductSpecificationsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ProductSizeSpecifications",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSpecifications_ProductSpecificationId",
                table: "Products",
                column: "ProductSpecificationId",
                principalTable: "ProductSpecifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeSpecifications_ProductSpecifications_ProductSpecificationId",
                table: "ProductSizeSpecifications",
                column: "ProductSpecificationId",
                principalTable: "ProductSpecifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class UpdateMenuConfiguraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Restaurants_RestaurantId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantSpecifications_Restaurants_RestaurantId",
                table: "RestaurantSpecifications");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 10, 2, 11, 15, 150, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Restaurants_RestaurantId",
                table: "Menus",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantSpecifications_Restaurants_RestaurantId",
                table: "RestaurantSpecifications",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Restaurants_RestaurantId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantSpecifications_Restaurants_RestaurantId",
                table: "RestaurantSpecifications");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ProductSizeSpecifications",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "RestaurantSpecifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 10, 9, 13, 29, 43, 881, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Restaurants_RestaurantId",
                table: "Menus",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantSpecifications_Restaurants_RestaurantId",
                table: "RestaurantSpecifications",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

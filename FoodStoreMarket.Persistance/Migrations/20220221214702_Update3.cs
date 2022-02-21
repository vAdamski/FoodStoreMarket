using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_RestaurantSpecifications_RestaurantSpecificationId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_RestaurantSpecificationId",
                table: "Restaurants");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantSpecificationId",
                table: "Restaurants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantSpecificationId",
                table: "Restaurants",
                column: "RestaurantSpecificationId",
                unique: true,
                filter: "[RestaurantSpecificationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_RestaurantSpecifications_RestaurantSpecificationId",
                table: "Restaurants",
                column: "RestaurantSpecificationId",
                principalTable: "RestaurantSpecifications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_RestaurantSpecifications_RestaurantSpecificationId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_RestaurantSpecificationId",
                table: "Restaurants");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantSpecificationId",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantSpecificationId",
                table: "Restaurants",
                column: "RestaurantSpecificationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_RestaurantSpecifications_RestaurantSpecificationId",
                table: "Restaurants",
                column: "RestaurantSpecificationId",
                principalTable: "RestaurantSpecifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

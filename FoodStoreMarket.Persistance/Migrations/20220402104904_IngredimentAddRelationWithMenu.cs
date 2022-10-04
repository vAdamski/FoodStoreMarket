using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class IngredimentAddRelationWithMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MenuId",
                table: "Ingredients",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Menus_MenuId",
                table: "Ingredients",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Menus_MenuId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_MenuId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Ingredients");
        }
    }
}

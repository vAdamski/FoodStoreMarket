using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class InitialCreateProductTypeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientProductSpecification_ProductSpecification_ProductSpecificationsId",
                table: "IngredientProductSpecification");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSpecification_ProductSpecificationId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeSpecification_ProductSpecification_ProductSpecificationId",
                table: "ProductSizeSpecification");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeSpecification_Sizes_SizeId",
                table: "ProductSizeSpecification");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecification_ProductTypes_ProductTypeId",
                table: "ProductSpecification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecification",
                table: "ProductSpecification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizeSpecification",
                table: "ProductSizeSpecification");

            migrationBuilder.RenameTable(
                name: "ProductSpecification",
                newName: "ProductSpecifications");

            migrationBuilder.RenameTable(
                name: "ProductSizeSpecification",
                newName: "ProductSizeSpecifications");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSpecification_ProductTypeId",
                table: "ProductSpecifications",
                newName: "IX_ProductSpecifications_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeSpecification_SizeId",
                table: "ProductSizeSpecifications",
                newName: "IX_ProductSizeSpecifications_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeSpecification_ProductSpecificationId",
                table: "ProductSizeSpecifications",
                newName: "IX_ProductSizeSpecifications_ProductSpecificationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizeSpecifications",
                table: "ProductSizeSpecifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientProductSpecification_ProductSpecifications_ProductSpecificationsId",
                table: "IngredientProductSpecification",
                column: "ProductSpecificationsId",
                principalTable: "ProductSpecifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeSpecifications_Sizes_SizeId",
                table: "ProductSizeSpecifications",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId",
                table: "ProductSpecifications",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientProductSpecification_ProductSpecifications_ProductSpecificationsId",
                table: "IngredientProductSpecification");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSpecifications_ProductSpecificationId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeSpecifications_ProductSpecifications_ProductSpecificationId",
                table: "ProductSizeSpecifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeSpecifications_Sizes_SizeId",
                table: "ProductSizeSpecifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_ProductTypes_ProductTypeId",
                table: "ProductSpecifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizeSpecifications",
                table: "ProductSizeSpecifications");

            migrationBuilder.RenameTable(
                name: "ProductSpecifications",
                newName: "ProductSpecification");

            migrationBuilder.RenameTable(
                name: "ProductSizeSpecifications",
                newName: "ProductSizeSpecification");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSpecifications_ProductTypeId",
                table: "ProductSpecification",
                newName: "IX_ProductSpecification_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeSpecifications_SizeId",
                table: "ProductSizeSpecification",
                newName: "IX_ProductSizeSpecification_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeSpecifications_ProductSpecificationId",
                table: "ProductSizeSpecification",
                newName: "IX_ProductSizeSpecification_ProductSpecificationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecification",
                table: "ProductSpecification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizeSpecification",
                table: "ProductSizeSpecification",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientProductSpecification_ProductSpecification_ProductSpecificationsId",
                table: "IngredientProductSpecification",
                column: "ProductSpecificationsId",
                principalTable: "ProductSpecification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSpecification_ProductSpecificationId",
                table: "Products",
                column: "ProductSpecificationId",
                principalTable: "ProductSpecification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeSpecification_ProductSpecification_ProductSpecificationId",
                table: "ProductSizeSpecification",
                column: "ProductSpecificationId",
                principalTable: "ProductSpecification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeSpecification_Sizes_SizeId",
                table: "ProductSizeSpecification",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecification_ProductTypes_ProductTypeId",
                table: "ProductSpecification",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");
        }
    }
}

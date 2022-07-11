using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class SizeUpdateV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientProductSpecification_ProductSpecifications_ProductSpecificationsId",
                table: "IngredientProductSpecification");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSpecifications_ProductSpecificationId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "IngredientSizeDetails");

            migrationBuilder.DropTable(
                name: "ProductSizeDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ingredients");

            migrationBuilder.RenameTable(
                name: "ProductSpecifications",
                newName: "ProductSpecification");

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "Sizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "ProductSpecification",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecification",
                table: "ProductSpecification",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductSizeSpecification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSpecificationId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizeSpecification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizeSpecification_ProductSpecification_ProductSpecificationId",
                        column: x => x.ProductSpecificationId,
                        principalTable: "ProductSpecification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizeSpecification_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_ProductTypeId",
                table: "Sizes",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecification_ProductTypeId",
                table: "ProductSpecification",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeSpecification_ProductSpecificationId",
                table: "ProductSizeSpecification",
                column: "ProductSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeSpecification_SizeId",
                table: "ProductSizeSpecification",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_MenuId",
                table: "ProductTypes",
                column: "MenuId");

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
                name: "FK_ProductSpecification_ProductTypes_ProductTypeId",
                table: "ProductSpecification",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_ProductTypes_ProductTypeId",
                table: "Sizes",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientProductSpecification_ProductSpecification_ProductSpecificationsId",
                table: "IngredientProductSpecification");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSpecification_ProductSpecificationId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecification_ProductTypes_ProductTypeId",
                table: "ProductSpecification");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_ProductTypes_ProductTypeId",
                table: "Sizes");

            migrationBuilder.DropTable(
                name: "ProductSizeSpecification");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_Sizes_ProductTypeId",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecification",
                table: "ProductSpecification");

            migrationBuilder.DropIndex(
                name: "IX_ProductSpecification_ProductTypeId",
                table: "ProductSpecification");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "ProductSpecification");

            migrationBuilder.RenameTable(
                name: "ProductSpecification",
                newName: "ProductSpecifications");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Ingredients",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IngredientSizeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientSizeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientSizeDetails_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientSizeDetails_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSizeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSpecificationId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizeDetails_ProductSpecifications_ProductSpecificationId",
                        column: x => x.ProductSpecificationId,
                        principalTable: "ProductSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizeDetails_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSizeDetails_IngredientId",
                table: "IngredientSizeDetails",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSizeDetails_SizeId",
                table: "IngredientSizeDetails",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeDetails_ProductSpecificationId",
                table: "ProductSizeDetails",
                column: "ProductSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeDetails_SizeId",
                table: "ProductSizeDetails",
                column: "SizeId");

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
        }
    }
}

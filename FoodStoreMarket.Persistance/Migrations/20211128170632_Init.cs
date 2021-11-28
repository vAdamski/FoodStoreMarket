using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonName_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_FlatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indegriments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Indegriments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpeningClosingSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantSpecificationId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_OpeningClosingSpecifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ProductSpecifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Adres_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_FlatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfAccepted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfScheduledDelivery = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpeningClosingHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpeningClosingSpecificationId = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningTime_Hour = table.Column<int>(type: "int", nullable: true),
                    OpeningTime_Minute = table.Column<int>(type: "int", nullable: true),
                    OpeningTime_Secound = table.Column<int>(type: "int", nullable: true),
                    ClosingTime_Hour = table.Column<int>(type: "int", nullable: true),
                    ClosingTime_Minute = table.Column<int>(type: "int", nullable: true),
                    ClosingTime_Secound = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_OpeningClosingHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpeningClosingHours_OpeningClosingSpecifications_OpeningClosingSpecificationId",
                        column: x => x.OpeningClosingSpecificationId,
                        principalTable: "OpeningClosingSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_FlatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningClosingSpecificationId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_RestaurantSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantSpecifications_OpeningClosingSpecifications_OpeningClosingSpecificationId",
                        column: x => x.OpeningClosingSpecificationId,
                        principalTable: "OpeningClosingSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndegrimentProductSpecification",
                columns: table => new
                {
                    IndegrimentsId = table.Column<int>(type: "int", nullable: false),
                    ProductSpecificationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndegrimentProductSpecification", x => new { x.IndegrimentsId, x.ProductSpecificationsId });
                    table.ForeignKey(
                        name: "FK_IndegrimentProductSpecification_Indegriments_IndegrimentsId",
                        column: x => x.IndegrimentsId,
                        principalTable: "Indegriments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndegrimentProductSpecification_ProductSpecifications_ProductSpecificationsId",
                        column: x => x.ProductSpecificationsId,
                        principalTable: "ProductSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    ProductSpecificationId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductSpecifications_ProductSpecificationId",
                        column: x => x.ProductSpecificationId,
                        principalTable: "ProductSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonName_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_FlatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantSpecificationId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_RestaurantSpecifications_RestaurantSpecificationId",
                        column: x => x.RestaurantSpecificationId,
                        principalTable: "RestaurantSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    RestaurantSpecificationId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurants_RestaurantSpecifications_RestaurantSpecificationId",
                        column: x => x.RestaurantSpecificationId,
                        principalTable: "RestaurantSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkingHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateOfStartWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfEndWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    table.PrimaryKey("PK_WorkingHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkingHours_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RestaurantSpecificationId",
                table: "Employees",
                column: "RestaurantSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndegrimentProductSpecification_ProductSpecificationsId",
                table: "IndegrimentProductSpecification",
                column: "ProductSpecificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningClosingHours_OpeningClosingSpecificationId",
                table: "OpeningClosingHours",
                column: "OpeningClosingSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MenuId",
                table: "Products",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSpecificationId",
                table: "Products",
                column: "ProductSpecificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_MenuId",
                table: "Restaurants",
                column: "MenuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantSpecificationId",
                table: "Restaurants",
                column: "RestaurantSpecificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantSpecifications_OpeningClosingSpecificationId",
                table: "RestaurantSpecifications",
                column: "OpeningClosingSpecificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkingHours_EmployeeId",
                table: "WorkingHours",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndegrimentProductSpecification");

            migrationBuilder.DropTable(
                name: "OpeningClosingHours");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "WorkingHours");

            migrationBuilder.DropTable(
                name: "Indegriments");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "RestaurantSpecifications");

            migrationBuilder.DropTable(
                name: "OpeningClosingSpecifications");
        }
    }
}

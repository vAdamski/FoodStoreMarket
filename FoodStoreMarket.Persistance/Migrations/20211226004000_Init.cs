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
                name: "ProductSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    OpeningClosingSpecificationId = table.Column<int>(type: "int", nullable: true),
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
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantSpecificationId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_RestaurantSpecifications_RestaurantSpecificationId",
                        column: x => x.RestaurantSpecificationId,
                        principalTable: "RestaurantSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_OpeningClosingSpecifications_RestaurantSpecifications_RestaurantSpecificationId",
                        column: x => x.RestaurantSpecificationId,
                        principalTable: "RestaurantSpecifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Restaurants_RestaurantSpecifications_RestaurantSpecificationId",
                        column: x => x.RestaurantSpecificationId,
                        principalTable: "RestaurantSpecifications",
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
                    DateOfEndWork = table.Column<DateTime>(type: "datetime2", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "OpeningClosingHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpeningClosingSpecificationId = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Menus_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    ProductSpecificationId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "Indegriments",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5822), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mutton meat", 0m, 1 },
                    { 2, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5831), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chicken meat", 0m, 1 },
                    { 3, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5836), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Salad", 0m, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "ProductId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5787), null, "Kebab w Tortilli", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kebab", 1, 1 },
                    { 2, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5797), null, "Fizzy Drink", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pepsi", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "OpeningClosingSpecificationId", "RestaurantId", "StatusId", "Adres_City", "Adres_Email", "Adres_FlatNumber", "Adres_HouseNumber", "Adres_PhoneNumber", "Adres_PostCode", "Adres_Street" },
                values: new object[] { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4153), null, "Best Kebab in Lodz", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BestKebab", null, 1, 1, "Lodz", "bestkebab@gmail.com", null, "16", "123456789", "94-042", "Olimpijska" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId", "Adres_City", "Adres_Email", "Adres_FlatNumber", "Adres_HouseNumber", "Adres_PhoneNumber", "Adres_PostCode", "Adres_Street", "PersonName_FirstName", "PersonName_LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4385), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "Lodz", "mateusz.nowak@gmail.com", "1", "10", "112233445", "94-042", "Rajdowa", "Mateusz", "Nowak" },
                    { 2, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4643), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "Lodz", "mariusz.gruszka@gmail.com", "44", "80", "987654321", "94-042", "Retkinska", "Mariusz", "Gruszka" }
                });

            migrationBuilder.InsertData(
                table: "OpeningClosingSpecifications",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4813), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "RestaurantSpecificationId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4019), null, null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "RestaurantId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5729), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "OpeningClosingHours",
                columns: new[] { "Id", "Created", "CreatedBy", "Day", "Inactivated", "InactivatedBy", "IsOpen", "Modified", "ModifiedBy", "OpeningClosingSpecificationId", "StatusId", "ClosingTime_Hour", "ClosingTime_Minute", "ClosingTime_Secound", "OpeningTime_Hour", "OpeningTime_Minute", "OpeningTime_Secound" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(4846), null, "Monday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 2, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5036), null, "Tuesday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 3, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5220), null, "Wednesday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 4, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5362), null, "Thursday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 },
                    { 5, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5502), null, "Friday", null, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 20, 0, 0, 8, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "OpeningClosingHours",
                columns: new[] { "Id", "Created", "CreatedBy", "Day", "Inactivated", "InactivatedBy", "IsOpen", "Modified", "ModifiedBy", "OpeningClosingSpecificationId", "StatusId" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5690), null, "Saturday", null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 },
                    { 7, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5699), null, "Sunday", null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "ProductSpecificationId", "StatusId" },
                values: new object[] { 1, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5752), null, null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "MenuId", "Modified", "ModifiedBy", "ProductSpecificationId", "StatusId" },
                values: new object[] { 2, new DateTime(2021, 12, 26, 1, 40, 0, 358, DateTimeKind.Local).AddTicks(5760), null, null, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RestaurantSpecificationId",
                table: "Employees",
                column: "RestaurantSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndegrimentProductSpecification_ProductSpecificationsId",
                table: "IndegrimentProductSpecification",
                column: "ProductSpecificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_RestaurantId",
                table: "Menus",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpeningClosingHours_OpeningClosingSpecificationId",
                table: "OpeningClosingHours",
                column: "OpeningClosingSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningClosingSpecifications_RestaurantSpecificationId",
                table: "OpeningClosingSpecifications",
                column: "RestaurantSpecificationId",
                unique: true);

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
                unique: true,
                filter: "[ProductSpecificationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantSpecificationId",
                table: "Restaurants",
                column: "RestaurantSpecificationId",
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
                name: "WorkingHours");

            migrationBuilder.DropTable(
                name: "Indegriments");

            migrationBuilder.DropTable(
                name: "OpeningClosingSpecifications");

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
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "RestaurantSpecifications");
        }
    }
}

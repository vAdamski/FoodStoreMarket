﻿// <auto-generated />
using System;
using FoodStoreMarket.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodStoreMarket.Persistance.Migrations
{
    [DbContext(typeof(FoodStoreMarketDbContext))]
    [Migration("20220424232155_RestaurantOnDeleteI")]
    partial class RestaurantOnDeleteI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantSpecificationId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantSpecificationId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.OpeningClosingHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpeningClosingSpecificationId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OpeningClosingSpecificationId");

                    b.ToTable("OpeningClosingHours");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.OpeningClosingSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantSpecificationId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantSpecificationId")
                        .IsUnique();

                    b.ToTable("OpeningClosingSpecifications");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfAccepted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfScheduledDelivery")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductSpecificationId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("ProductSpecificationId")
                        .IsUnique()
                        .HasFilter("[ProductSpecificationId] IS NOT NULL");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.ProductSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductSpecifications");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.RestaurantSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("OpeningClosingSpecificationId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("RestaurantSpecifications");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.WorkingHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfEndWork")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfStartWork")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<decimal?>("WorkHours")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkingHours");
                });

            modelBuilder.Entity("IngredientProductSpecification", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductSpecificationsId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsId", "ProductSpecificationsId");

                    b.HasIndex("ProductSpecificationsId");

                    b.ToTable("IngredientProductSpecification");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Client", b =>
                {
                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.Adres", "Adres", b1 =>
                        {
                            b1.Property<int>("ClientId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("FlatNumber")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("HouseNumber")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("nvarchar(9)");

                            b1.Property<string>("PostCode")
                                .IsRequired()
                                .HasMaxLength(6)
                                .HasColumnType("nvarchar(6)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.HasKey("ClientId");

                            b1.ToTable("Clients");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.PersonName", "PersonName", b1 =>
                        {
                            b1.Property<int>("ClientId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)");

                            b1.HasKey("ClientId");

                            b1.ToTable("Clients");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.Navigation("Adres");

                    b.Navigation("PersonName");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Employee", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.RestaurantSpecification", "RestaurantSpecification")
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantSpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.Adres", "Adres", b1 =>
                        {
                            b1.Property<int>("EmployeeId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("FlatNumber")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("HouseNumber")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("nvarchar(9)");

                            b1.Property<string>("PostCode")
                                .IsRequired()
                                .HasMaxLength(6)
                                .HasColumnType("nvarchar(6)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.HasKey("EmployeeId");

                            b1.ToTable("Employees");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");
                        });

                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.PersonName", "PersonName", b1 =>
                        {
                            b1.Property<int>("EmployeeId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)");

                            b1.HasKey("EmployeeId");

                            b1.ToTable("Employees");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");
                        });

                    b.Navigation("Adres");

                    b.Navigation("PersonName");

                    b.Navigation("RestaurantSpecification");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Ingredient", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Menu", "Menu")
                        .WithMany("Ingredients")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Menu", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Restaurant", "Restaurant")
                        .WithOne("Menu")
                        .HasForeignKey("FoodStoreMarket.Domain.Entities.Menu", "RestaurantId");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.OpeningClosingHours", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.OpeningClosingSpecification", "OpeningClosingSpecification")
                        .WithMany("OpeningClosingHours")
                        .HasForeignKey("OpeningClosingSpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.Time", "ClosingTime", b1 =>
                        {
                            b1.Property<int>("OpeningClosingHoursId")
                                .HasColumnType("int");

                            b1.Property<int>("Hour")
                                .HasColumnType("int");

                            b1.Property<int>("Minute")
                                .HasColumnType("int");

                            b1.Property<int>("Secound")
                                .HasColumnType("int");

                            b1.HasKey("OpeningClosingHoursId");

                            b1.ToTable("OpeningClosingHours");

                            b1.WithOwner()
                                .HasForeignKey("OpeningClosingHoursId");
                        });

                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.Time", "OpeningTime", b1 =>
                        {
                            b1.Property<int>("OpeningClosingHoursId")
                                .HasColumnType("int");

                            b1.Property<int>("Hour")
                                .HasColumnType("int");

                            b1.Property<int>("Minute")
                                .HasColumnType("int");

                            b1.Property<int>("Secound")
                                .HasColumnType("int");

                            b1.HasKey("OpeningClosingHoursId");

                            b1.ToTable("OpeningClosingHours");

                            b1.WithOwner()
                                .HasForeignKey("OpeningClosingHoursId");
                        });

                    b.Navigation("ClosingTime");

                    b.Navigation("OpeningClosingSpecification");

                    b.Navigation("OpeningTime");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.OpeningClosingSpecification", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.RestaurantSpecification", "RestaurantSpecification")
                        .WithOne("OpeningClosingSpecification")
                        .HasForeignKey("FoodStoreMarket.Domain.Entities.OpeningClosingSpecification", "RestaurantSpecificationId");

                    b.Navigation("RestaurantSpecification");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Order", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.Adres", "Adres", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("FlatNumber")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("HouseNumber")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("nvarchar(9)");

                            b1.Property<string>("PostCode")
                                .IsRequired()
                                .HasMaxLength(6)
                                .HasColumnType("nvarchar(6)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.Navigation("Adres");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Product", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Menu", "Menu")
                        .WithMany("Products")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodStoreMarket.Domain.Entities.ProductSpecification", "ProductSpecification")
                        .WithOne("Product")
                        .HasForeignKey("FoodStoreMarket.Domain.Entities.Product", "ProductSpecificationId");

                    b.Navigation("Menu");

                    b.Navigation("ProductSpecification");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.RestaurantSpecification", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Restaurant", "Restaurant")
                        .WithOne("RestaurantSpecification")
                        .HasForeignKey("FoodStoreMarket.Domain.Entities.RestaurantSpecification", "RestaurantId");

                    b.OwnsOne("FoodStoreMarket.Domain.ValueObjects.Adres", "Adres", b1 =>
                        {
                            b1.Property<int>("RestaurantSpecificationId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("FlatNumber")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("HouseNumber")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("nvarchar(9)");

                            b1.Property<string>("PostCode")
                                .IsRequired()
                                .HasMaxLength(6)
                                .HasColumnType("nvarchar(6)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.HasKey("RestaurantSpecificationId");

                            b1.ToTable("RestaurantSpecifications");

                            b1.WithOwner()
                                .HasForeignKey("RestaurantSpecificationId");
                        });

                    b.Navigation("Adres");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.WorkingHours", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Employee", "Employee")
                        .WithMany("WorkingHours")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("IngredientProductSpecification", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodStoreMarket.Domain.Entities.ProductSpecification", null)
                        .WithMany()
                        .HasForeignKey("ProductSpecificationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("FoodStoreMarket.Domain.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodStoreMarket.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Employee", b =>
                {
                    b.Navigation("WorkingHours");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Menu", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.OpeningClosingSpecification", b =>
                {
                    b.Navigation("OpeningClosingHours");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.ProductSpecification", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.Restaurant", b =>
                {
                    b.Navigation("Menu");

                    b.Navigation("RestaurantSpecification");
                });

            modelBuilder.Entity("FoodStoreMarket.Domain.Entities.RestaurantSpecification", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("OpeningClosingSpecification");
                });
#pragma warning restore 612, 618
        }
    }
}

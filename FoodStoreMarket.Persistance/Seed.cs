using System;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            SeedRestaurant(modelBuilder);
            SeedMenu(modelBuilder);
            SeedRestaurantSpecification(modelBuilder);
            SeedProductType(modelBuilder);
            SeedSize(modelBuilder);
            SeedIngredients(modelBuilder);
            SeedProduct(modelBuilder);
            SeedProductSpecification(modelBuilder);
            SeedProductSizeSpecification(modelBuilder);
        }

        
        private static void SeedRestaurant(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>(r =>
            {
                r.HasData(new Restaurant()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "ALICESMITH@EMAIL.COM"
                });
            });
        }
        private static void SeedMenu(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(m =>
            {
                m.HasData(new Menu()
                {
                    Id = 1,
                    RestaurantId = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "ALICESMITH@EMAIL.COM"
                });
            });
        }
        private static void SeedRestaurantSpecification(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantSpecification>(rs =>
            {
                rs.HasData(new RestaurantSpecification()
                {
                    Id = 1,
                    RestaurantId = 1,
                    Name = "Pizzeria #1",
                    Description = "Pizzeria na osiedlu",
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "ALICESMITH@EMAIL.COM"
                });

                rs.OwnsOne(rs => rs.Adres).HasData(new
                {
                    RestaurantSpecificationId = 1,
                    City = "Lodz",
                    PostCode = "94-000",
                    Street = "al.Politechniki",
                    HouseNumber = "1",
                    FlatNumber = "",
                    PhoneNumber = "123456789",
                    Email = "PIZZERIA@GMAIL.COM"
                });
            });
        }
        private static void SeedProductType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>(pt =>
            {
                pt.HasData(
                    //PIZZA PRODUCT TYPE
                    new ProductType()
                    {
                        Id = 1,
                        MenuId = 1,
                        ProductTypeName = "Pizza",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //DRINK PRODUCT TYPE (Cola, Sprite, etc.)
                    new ProductType()
                    {
                        Id = 2,
                        MenuId = 1,
                        ProductTypeName = "Drink",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new ProductType()
                    {
                        Id = 3,
                        MenuId = 1,
                        ProductTypeName = "Beer",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    }
                );
            });
        }
        private static void SeedSize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>(s =>
            {
                s.HasData(
                    //PIZZAS SIZE SEED
                    new Size()
                    {
                        Id = 1,
                        MenuId = 1,
                        ProductTypeId = 1,
                        SizeName = "Small 26cm",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 2,
                        MenuId = 1,
                        ProductTypeId = 1,
                        SizeName = "Medium 32cm",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 3,
                        MenuId = 1,
                        ProductTypeId = 1,
                        SizeName = "Big 42cm",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //DRINK SIZE SEED
                    new Size()
                    {
                        Id = 4,
                        MenuId = 1,
                        ProductTypeId = 2,
                        SizeName = "500ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 5,
                        MenuId = 1,
                        ProductTypeId = 2,
                        SizeName = "850ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //BEER SIZE SEED
                    new Size()
                    {
                        Id = 6,
                        MenuId = 1,
                        ProductTypeId = 3,
                        SizeName = "300ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 7,
                        MenuId = 1,
                        ProductTypeId = 3,
                        SizeName = "500ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    }
                );
            });
        }
        private static void SeedIngredients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>(i =>
            {
                i.HasData(
                    new Ingredient()
                    {
                        Id= 1,
                        MenuId = 1,
                        Name = "Cheese",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 2,
                        MenuId = 1,
                        Name = "Sauce",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 3,
                        MenuId = 1,
                        Name = "Pepper",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 4,
                        MenuId = 1,
                        Name = "Ham",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 5,
                        MenuId = 1,
                        Name = "Mushrooms",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 6,
                        MenuId = 1,
                        Name = "Pineapple",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    }
                );
            });
        }
        private static void SeedProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(p =>
            {
                p.HasData(
                    //PIZZAS
                    new Product()
                    {
                        Id = 1,
                        MenuId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 2,
                        MenuId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 3,
                        MenuId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //DRINKS
                    new Product()
                    {
                        Id = 4,
                        MenuId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 5,
                        MenuId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //BEER
                    new Product()
                    {
                        Id = 6,
                        MenuId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 7,
                        MenuId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    }
                );
            });
        }
        private static void SeedProductSpecification(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSpecification>(ps =>
            {
                ps.HasData(
                   new ProductSpecification()
                   {
                       Id = 1,
                       ProductId = 1,
                       Name = "PIZZA #1",
                       Description = "",
                       ProductTypeId = 1,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "ALICESMITH@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 2,
                       ProductId = 2,
                       Name = "PIZZA #2",
                       Description = "",
                       ProductTypeId = 1,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "ALICESMITH@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 3,
                       ProductId = 3,
                       Name = "PIZZA #3",
                       Description = "",
                       ProductTypeId = 1,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "ALICESMITH@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 4,
                       ProductId = 4,
                       Name = "Cola",
                       Description = "",
                       ProductTypeId = 1,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "ALICESMITH@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 5,
                       ProductId = 5,
                       Name = "Sprite",
                       Description = "",
                       ProductTypeId = 1,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "ALICESMITH@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 6,
                       ProductId = 6,
                       Name = "Zatecky",
                       Description = "",
                       ProductTypeId = 1,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "ALICESMITH@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 7,
                       ProductId = 7,
                       Name = "Lech",
                       Description = "",
                       ProductTypeId = 1,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "ALICESMITH@EMAIL.COM"
                   }
                );
                ps.HasMany(ps => ps.Ingredients)
                    .WithMany(i => i.ProductSpecifications)
                    .UsingEntity(j => j.ToTable("IngredientProductSpecification")
                        .HasData(new[]
                            {
                                //PIZZA #1
                                new {IngredientsId = 1, ProductSpecificationsId = 1},
                                new {IngredientsId = 2, ProductSpecificationsId = 1},
                                //PIZZA #2                                  
                                new {IngredientsId = 1, ProductSpecificationsId = 2},
                                new {IngredientsId = 2, ProductSpecificationsId = 2},
                                new {IngredientsId = 3, ProductSpecificationsId = 2},
                                new {IngredientsId = 4, ProductSpecificationsId = 2},
                                new {IngredientsId = 5, ProductSpecificationsId = 2},
                                //PIZZA #2                                  
                                new {IngredientsId = 1, ProductSpecificationsId = 3},
                                new {IngredientsId = 2, ProductSpecificationsId = 3},
                                new {IngredientsId = 4, ProductSpecificationsId = 3},
                                new {IngredientsId = 6, ProductSpecificationsId = 3},
                            }));
            });
            
            
        }
        private static void SeedProductSizeSpecification(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSizeSpecification>(pss =>
            {
                pss.HasData
                (
                    //PIZZA #1 Small
                    new ProductSizeSpecification()
                    {
                        Id = 1,
                        ProductSpecificationId = 1,
                        SizeId = 1,
                        Price = 20.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #1 Medium
                    new ProductSizeSpecification()
                    {
                        Id = 2,
                        ProductSpecificationId = 1,
                        SizeId = 2,
                        Price = 25.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #1 Big
                    new ProductSizeSpecification()
                    {
                        Id = 3,
                        ProductSpecificationId = 1,
                        SizeId = 3,
                        Price = 30.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #2 Small
                    new ProductSizeSpecification()
                    {
                        Id = 4,
                        ProductSpecificationId = 2,
                        SizeId = 1,
                        Price = 22.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #2 Medium
                    new ProductSizeSpecification()
                    {
                        Id = 5,
                        ProductSpecificationId = 2,
                        SizeId = 2,
                        Price = 27.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #2 Big
                    new ProductSizeSpecification()
                    {
                        Id = 6,
                        ProductSpecificationId = 2,
                        SizeId = 3,
                        Price = 33.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #3 Small
                    new ProductSizeSpecification()
                    {
                        Id = 7,
                        ProductSpecificationId = 3,
                        SizeId = 1,
                        Price = 25.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #3 Medium
                    new ProductSizeSpecification()
                    {
                        Id = 8,
                        ProductSpecificationId = 3,
                        SizeId = 2,
                        Price = 30.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //PIZZA #3 Big
                    new ProductSizeSpecification()
                    {
                        Id = 9,
                        ProductSpecificationId = 3,
                        SizeId = 3,
                        Price = 35.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //COLA 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 10,
                        ProductSpecificationId = 4,
                        SizeId = 4,
                        Price = 7.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //COLA 850ml
                    new ProductSizeSpecification()
                    {
                        Id = 11,
                        ProductSpecificationId = 4,
                        SizeId = 5,
                        Price = 9.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //SPRITE 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 12,
                        ProductSpecificationId = 5,
                        SizeId = 4,
                        Price = 7.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //LECH 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 13,
                        ProductSpecificationId = 7,
                        SizeId = 1,
                        Price = 8.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //ZATECKY 300ml
                    new ProductSizeSpecification()
                    {
                        Id = 14,
                        ProductSpecificationId = 6,
                        SizeId = 6,
                        Price = 8.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //ZATECKY 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 15,
                        ProductSpecificationId = 6,
                        SizeId = 7,
                        Price = 10.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    }
                );
            });
        }
    }
}


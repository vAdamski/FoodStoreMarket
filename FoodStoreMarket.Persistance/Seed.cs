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
                
                r.HasData(new Restaurant()
                {
                    Id = 2,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "BOBMERTENS@EMAIL.COM"
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
                
                m.HasData(new Menu()
                {
                    Id = 2,
                    RestaurantId = 2,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "BOBMERTENS@EMAIL.COM"
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
                
                rs.HasData(new RestaurantSpecification()
                {
                    Id = 2,
                    RestaurantId = 2,
                    Name = "Pizzeria #2",
                    Description = "Kebab na Widzewie",
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "BOBMERTENS@EMAIL.COM"
                });

                rs.OwnsOne(rs => rs.Adres).HasData(new
                {
                    RestaurantSpecificationId = 2,
                    City = "Lodz",
                    PostCode = "94-000",
                    Street = "al.Widzewska",
                    HouseNumber = "77",
                    FlatNumber = "",
                    PhoneNumber = "111222333",
                    Email = "WIDZEWSKIKEBEAB@GMAIL.COM"
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
                    },
                    
                    //KEBAB PRODUCT TYPE
                    new ProductType()
                    {
                        Id = 4,
                        MenuId = 2,
                        ProductTypeName = "Kebab",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //DRINK PRODUCT TYPE (Cola, Sprite, etc.)
                    new ProductType()
                    {
                        Id = 5,
                        MenuId = 2,
                        ProductTypeName = "Drink",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new ProductType()
                    {
                        Id = 6,
                        MenuId = 2,
                        ProductTypeName = "Beer",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
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
                        ProductTypeId = 5,
                        SizeName = "500ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 5,
                        MenuId = 1,
                        ProductTypeId = 5,
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
                        ProductTypeId = 6,
                        SizeName = "300ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 7,
                        MenuId = 1,
                        ProductTypeId = 6,
                        SizeName = "500ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    
                    //KEBAB SIZE SEED
                    new Size()
                    {
                        Id = 8,
                        MenuId = 2,
                        ProductTypeId = 4,
                        SizeName = "M",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 9,
                        MenuId = 2,
                        ProductTypeId = 4,
                        SizeName = "L",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 10,
                        MenuId = 2,
                        ProductTypeId = 4,
                        SizeName = "XL",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //DRINK SIZE SEED
                    new Size()
                    {
                        Id = 11,
                        MenuId = 2,
                        ProductTypeId = 5,
                        SizeName = "500ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 12,
                        MenuId = 2,
                        ProductTypeId = 5,
                        SizeName = "850ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //BEER SIZE SEED
                    new Size()
                    {
                        Id = 13,
                        MenuId = 2,
                        ProductTypeId = 6,
                        SizeName = "300ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Size()
                    {
                        Id = 14,
                        MenuId = 2,
                        ProductTypeId = 6,
                        SizeName = "500ml",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    }
                );
            });
        }
        private static void SeedIngredients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>(i =>
            {
                i.HasData(
                    // PIZZA RESTAURANT
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
                    },
                    
                    //KEBAB RESTAURANT
                    new Ingredient()
                    {
                        Id= 7,
                        MenuId = 2,
                        Name = "Mutton",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 8,
                        MenuId = 2,
                        Name = "Chicken",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 9,
                        MenuId = 2,
                        Name = "Salad",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 10,
                        MenuId = 2,
                        Name = "Tomato",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 11,
                        MenuId = 2,
                        Name = "Cucumber",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Ingredient()
                    {
                        Id= 12,
                        MenuId = 2,
                        Name = "Jalapeno",
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    }
                );
            });
        }
        
        //TODO: Rest of the new restaurant
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
                        ProductSpecificationId = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 2,
                        MenuId = 1,
                        ProductSpecificationId = 2,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 3,
                        MenuId = 1,
                        ProductSpecificationId = 3,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //DRINKS
                    new Product()
                    {
                        Id = 4,
                        MenuId = 1,
                        ProductSpecificationId = 4,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 5,
                        MenuId = 1,
                        ProductSpecificationId = 5,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    //BEER
                    new Product()
                    {
                        Id = 6,
                        MenuId = 1,
                        ProductSpecificationId = 6,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 7,
                        MenuId = 1,
                        ProductSpecificationId = 7,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "ALICESMITH@EMAIL.COM"
                    },
                    
                    //KEBAB
                    new Product()
                    {
                        Id = 8,
                        MenuId = 2,
                        ProductSpecificationId = 8,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 9,
                        MenuId = 2,
                        ProductSpecificationId = 9,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 10,
                        MenuId = 2,
                        ProductSpecificationId = 10,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //DRINKS
                    new Product()
                    {
                        Id = 11,
                        MenuId = 2,
                        ProductSpecificationId = 11,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 12,
                        MenuId = 2,
                        ProductSpecificationId = 12,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //BEER
                    new Product()
                    {
                        Id = 13,
                        MenuId = 2,
                        ProductSpecificationId = 13,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    new Product()
                    {
                        Id = 14,
                        MenuId = 2,
                        ProductSpecificationId = 14,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
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
                   },
                   
                   new ProductSpecification()
                   {
                       Id = 8,
                       ProductId = 8,
                       Name = "KEBAB #1",
                       Description = "",
                       ProductTypeId = 4,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "BOBMERTENS@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 9,
                       ProductId = 9,
                       Name = "KEBAB #2",
                       Description = "",
                       ProductTypeId = 4,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "BOBMERTENS@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 10,
                       ProductId = 10,
                       Name = "KEBAB #3",
                       Description = "",
                       ProductTypeId = 4,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "BOBMERTENS@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 11,
                       ProductId = 11,
                       Name = "Cola",
                       Description = "",
                       ProductTypeId = 5,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "BOBMERTENS@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 12,
                       ProductId = 12,
                       Name = "Sprite",
                       Description = "",
                       ProductTypeId = 5,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "BOBMERTENS@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 13,
                       ProductId = 13,
                       Name = "Zatecky",
                       Description = "",
                       ProductTypeId = 6,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "BOBMERTENS@EMAIL.COM"
                   },
                   new ProductSpecification()
                   {
                       Id = 14,
                       ProductId = 14,
                       Name = "Lech",
                       Description = "",
                       ProductTypeId = 6,
                       StatusId = 1,
                       Created = DateTime.Now,
                       CreatedBy = "BOBMERTENS@EMAIL.COM"
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
                                //PIZZA #3                                  
                                new {IngredientsId = 1, ProductSpecificationsId = 3},
                                new {IngredientsId = 2, ProductSpecificationsId = 3},
                                new {IngredientsId = 4, ProductSpecificationsId = 3},
                                new {IngredientsId = 6, ProductSpecificationsId = 3},
                                //KEBAB #1
                                new {IngredientsId = 8, ProductSpecificationsId = 8},
                                new {IngredientsId = 9, ProductSpecificationsId = 8},
                                new {IngredientsId = 10, ProductSpecificationsId = 8},
                                new {IngredientsId = 11, ProductSpecificationsId = 8},
                                //KEBAB #2                                  
                                new {IngredientsId = 7, ProductSpecificationsId = 9},
                                new {IngredientsId = 9, ProductSpecificationsId = 9},
                                new {IngredientsId = 10, ProductSpecificationsId = 9},
                                new {IngredientsId = 11, ProductSpecificationsId = 9},
                                //KEBAB #3                                  
                                new {IngredientsId = 7, ProductSpecificationsId = 10},
                                new {IngredientsId = 9, ProductSpecificationsId = 10},
                                new {IngredientsId = 10, ProductSpecificationsId = 10},
                                new {IngredientsId = 11, ProductSpecificationsId = 10},
                                new {IngredientsId = 12, ProductSpecificationsId = 10},
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
                    },
                    
                    //KEBAB #1 M
                    new ProductSizeSpecification()
                    {
                        Id = 16,
                        ProductSpecificationId = 8,
                        SizeId = 8,
                        Price = 10.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #1 L
                    new ProductSizeSpecification()
                    {
                        Id = 17,
                        ProductSpecificationId = 8,
                        SizeId = 9,
                        Price = 15.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #1 XL
                    new ProductSizeSpecification()
                    {
                        Id = 18,
                        ProductSpecificationId = 8,
                        SizeId = 10,
                        Price = 20.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #2 M
                    new ProductSizeSpecification()
                    {
                        Id = 19,
                        ProductSpecificationId = 9,
                        SizeId = 8,
                        Price = 10.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #2 L
                    new ProductSizeSpecification()
                    {
                        Id = 20,
                        ProductSpecificationId = 9,
                        SizeId = 9,
                        Price = 15.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #2 XL
                    new ProductSizeSpecification()
                    {
                        Id = 21,
                        ProductSpecificationId = 9,
                        SizeId = 10,
                        Price = 20.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #3 M
                    new ProductSizeSpecification()
                    {
                        Id = 22,
                        ProductSpecificationId = 10,
                        SizeId = 8,
                        Price = 12.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #3 L
                    new ProductSizeSpecification()
                    {
                        Id = 23,
                        ProductSpecificationId = 10,
                        SizeId = 9,
                        Price = 17.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //KEBAB #3 Xl
                    new ProductSizeSpecification()
                    {
                        Id = 24,
                        ProductSpecificationId = 10,
                        SizeId = 10,
                        Price = 22.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //COLA 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 25,
                        ProductSpecificationId = 11,
                        SizeId = 11,
                        Price = 7.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //COLA 850ml
                    new ProductSizeSpecification()
                    {
                        Id = 26,
                        ProductSpecificationId = 11,
                        SizeId = 12,
                        Price = 9.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //SPRITE 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 27,
                        ProductSpecificationId = 12,
                        SizeId = 11,
                        Price = 7.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //LECH 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 28,
                        ProductSpecificationId = 14,
                        SizeId = 14,
                        Price = 8.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //ZATECKY 300ml
                    new ProductSizeSpecification()
                    {
                        Id = 29,
                        ProductSpecificationId = 13,
                        SizeId = 13,
                        Price = 8.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    },
                    //ZATECKY 500ml
                    new ProductSizeSpecification()
                    {
                        Id = 30,
                        ProductSpecificationId = 13,
                        SizeId = 14,
                        Price = 10.00,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "BOBMERTENS@EMAIL.COM"
                    }
                );
            });
        }
    }
}


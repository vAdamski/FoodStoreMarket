using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.ValueObjects;
using FoodStoreMarket.Persistance;
using FoodStoreMarket.Persistance.Migrations;

namespace Application.UnitTests.Common;

public static class SeedMockData
{
    public static FoodStoreMarketDbContext SeedData(this FoodStoreMarketDbContext context)
    {
        return context;
    }

    private static void SeedRestaurant(FoodStoreMarketDbContext context)
    {
        var restaurant = new Restaurant()
        {
            Id = 1,
            StatusId = 1
        };
    }
    
    private static void SeedMenu(FoodStoreMarketDbContext context)
    {
        var menu = new Menu()
        {
            Id = 1,
            RestaurantId = 1,
            StatusId = 1
        };
    }
    
    private static void SeedRestaurantSpecification(FoodStoreMarketDbContext context)
    {
        var restaurantSpecification = new RestaurantSpecification()
        {
            Id = 1,
            RestaurantId = 1,
            Name = "Pizzeria #1",
            Description = "Pizzeria na osiedlu",
            Adres = new Adres()
            {
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123456789",
                Email = "PIZZERIA@GMAIL.COM"
            },
            StatusId = 1
        };
    }

    private static void SeedProductType(FoodStoreMarketDbContext context)
    {
        var productTypes = new List<ProductType>()
        {
            new ProductType()
            {
                Id = 1,
                MenuId = 1,
                ProductTypeName = "Pizza",
                StatusId = 1
            },
            new ProductType()
            {
                Id = 2,
                MenuId = 1,
                ProductTypeName = "Drink",
                StatusId = 1
            },
            new ProductType()
            {
                Id = 3,
                MenuId = 1,
                ProductTypeName = "Beer",
                StatusId = 1
            }
        };
    }

    private static void SeedSize(FoodStoreMarketDbContext context)
    {
        var sizes = new List<Size>()
        {
            new Size()
            {
                Id = 1,
                MenuId = 1,
                ProductTypeId = 1,
                SizeName = "Small 26cm",
                StatusId = 1
            },
            new Size()
            {
                Id = 2,
                MenuId = 1,
                ProductTypeId = 1,
                SizeName = "Medium 32cm",
                StatusId = 1
            },
            new Size()
            {
                Id = 3,
                MenuId = 1,
                ProductTypeId = 1,
                SizeName = "Big 42cm",
                StatusId = 1
            },
            //DRINK SIZE SEED
            new Size()
            {
                Id = 4,
                MenuId = 1,
                ProductTypeId = 2,
                SizeName = "500ml",
                StatusId = 1
            },
            new Size()
            {
                Id = 5,
                MenuId = 1,
                ProductTypeId = 2,
                SizeName = "850ml",
                StatusId = 1
            },
            //BEER SIZE SEED
            new Size()
            {
                Id = 6,
                MenuId = 1,
                ProductTypeId = 3,
                SizeName = "300ml",
                StatusId = 1
            },
            new Size()
            {
                Id = 7,
                MenuId = 1,
                ProductTypeId = 3,
                SizeName = "500ml",
                StatusId = 1
            }
        };
    }

    private static void SeedIngredients(FoodStoreMarketDbContext context)
    {
        var ingredients = new List<Ingredient>()
        {
            new Ingredient()
            {
                Id = 1,
                MenuId = 1,
                Name = "Cheese",
                StatusId = 1
            },
            new Ingredient()
            {
                Id = 2,
                MenuId = 1,
                Name = "Sauce",
                StatusId = 1
            },
            new Ingredient()
            {
                Id = 3,
                MenuId = 1,
                Name = "Pepper",
                StatusId = 1
            },
            new Ingredient()
            {
                Id = 4,
                MenuId = 1,
                Name = "Ham",
                StatusId = 1
            },
            new Ingredient()
            {
                Id = 5,
                MenuId = 1,
                Name = "Mushrooms",
                StatusId = 1
            },
            new Ingredient()
            {
                Id = 6,
                MenuId = 1,
                Name = "Pineapple",
                StatusId = 1
            }
        };
    }

    private static void SeedProduct(FoodStoreMarketDbContext context)
    {
        var products = new List<Product>()
        {
            //PIZZAS
            new Product()
            {
                Id = 1,
                MenuId = 1,
                StatusId = 1
            },
            new Product()
            {
                Id = 2,
                MenuId = 1,
                StatusId = 1
            },
            new Product()
            {
                Id = 3,
                MenuId = 1,
                StatusId = 1
            },
            //DRINKS
            new Product()
            {
                Id = 4,
                MenuId = 1,
                StatusId = 1
            },
            new Product()
            {
                Id = 5,
                MenuId = 1,
                StatusId = 1
            },
            //BEER
            new Product()
            {
                Id = 6,
                MenuId = 1,
                StatusId = 1
            },
            new Product()
            {
                Id = 7,
                MenuId = 1,
                StatusId = 1
            }
        };
    }

    private static void SeedProductSpecification(FoodStoreMarketDbContext context)
    {
        var productSpecification = new List<ProductSpecification>()
        {

        };
    }
}
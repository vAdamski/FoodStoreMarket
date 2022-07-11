using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Interfaces
{
    public interface IFoodStoreMarketDbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<OpeningClosingHours> OpeningClosingHours { get; set; }
        DbSet<OpeningClosingSpecification> OpeningClosingSpecifications { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductSizeSpecification> ProductSizeSpecifications { get; set; }
        DbSet<ProductSpecification> ProductSpecifications { get; set; }
        DbSet<ProductType> ProductTypes { get; set; }
        DbSet<Size> Sizes { get; set; }
        DbSet<Restaurant> Restaurants { get; set; }
        DbSet<RestaurantSpecification> RestaurantSpecifications { get; set; }
        DbSet<WorkingHours> WorkingHours { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

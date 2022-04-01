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
        DbSet<Restaurant> Restaurants { get; set; }
        DbSet<RestaurantSpecification> RestaurantSpecifications { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<WorkingHours> WorkingHours { get; set; }
        DbSet<OpeningClosingSpecification> OpeningClosingSpecifications { get; set; }
        DbSet<OpeningClosingHours> OpeningClosingHours { get; set; }
        DbSet<Domain.Entities.Menu> Menus { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductSpecification> ProductSpecifications { get; set; }
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Client> Clients { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

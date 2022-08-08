using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Persistance
{
    public class FoodStoreMarketDbContext : DbContext, IFoodStoreMarketDbContext
    {
        private readonly IDateTime _dateTime;
        private readonly ICurrentUserService _userService;
        public FoodStoreMarketDbContext(DbContextOptions<FoodStoreMarketDbContext> options) : base(options)
        {
        }
        
        public FoodStoreMarketDbContext(DbContextOptions<FoodStoreMarketDbContext> options, IDateTime dateTime, ICurrentUserService userService) : base(options)
        {
            _dateTime = dateTime;
            _userService = userService;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<OpeningClosingHours> OpeningClosingHours { get; set; }
        public DbSet<OpeningClosingSpecification> OpeningClosingSpecifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSizeSpecification> ProductSizeSpecifications { get; set; }
        public DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantSpecification> RestaurantSpecifications { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.SeedData();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = _userService.Email;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = _userService.Email;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = _userService.Email;
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _userService.Email;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    default:
                        break;
                }
            }

            foreach (var entry in ChangeTracker.Entries<ValueObject>())
            {
                switch (entry.State)
                {
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

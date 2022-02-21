using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Persistance
{
    public class FoodStoreMarketDbContext : DbContext, IFoodStoreMarketDbContext
    {
        private readonly IDateTime _dateTime;
        public FoodStoreMarketDbContext(DbContextOptions<FoodStoreMarketDbContext> options) : base(options)
        {

        }
        public FoodStoreMarketDbContext(DbContextOptions<FoodStoreMarketDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantSpecification> RestaurantSpecifications { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<OpeningClosingSpecification> OpeningClosingSpecifications { get; set; }
        public DbSet<OpeningClosingHours> OpeningClosingHours { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public DbSet<Indegriment> Indegriments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }

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
                        entry.Entity.ModifiedBy = String.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = String.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = String.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedBy = String.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

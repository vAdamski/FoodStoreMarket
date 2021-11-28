using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Persistance
{
    public class FoodStoreMarketDbContext : DbContext
    {
        public FoodStoreMarketDbContext(DbContextOptions<FoodStoreMarketDbContext> options) : base(options)
        {

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
            modelBuilder.Entity<Client>().OwnsOne(p => p.PersonName);
            modelBuilder.Entity<Client>().OwnsOne(p => p.Adres);
            modelBuilder.Entity<Employee>().OwnsOne(p => p.PersonName);
            modelBuilder.Entity<Employee>().OwnsOne(p => p.Adres);
            modelBuilder.Entity<OpeningClosingHours>().OwnsOne(p => p.ClosingTime);
            modelBuilder.Entity<OpeningClosingHours>().OwnsOne(p => p.OpeningTime);
            modelBuilder.Entity<RestaurantSpecification>().OwnsOne(p => p.Adres);
            modelBuilder.Entity<Order>().OwnsOne(p => p.Adres);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = String.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.InactivatedBy = String.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = String.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedBy = String.Empty;
                        entry.Entity.Created = DateTime.Now;
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

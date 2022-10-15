using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder
                .HasOne<RestaurantSpecification>(r => r.RestaurantSpecification)
                .WithOne(rs => rs.Restaurant)
                .HasForeignKey<RestaurantSpecification>(rs => rs.RestaurantId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);

            builder
                .HasOne<Menu>(r => r.Menu)
                .WithOne(m => m.Restaurant)
                .HasForeignKey<Menu>(m => m.RestaurantId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);
        }
    }
}


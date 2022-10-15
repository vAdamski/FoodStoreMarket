using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder
                .HasOne<Restaurant>(m => m.Restaurant)
                .WithOne(r => r.Menu)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}


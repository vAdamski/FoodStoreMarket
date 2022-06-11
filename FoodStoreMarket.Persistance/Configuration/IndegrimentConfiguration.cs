using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class IndegrimentConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.Property(i => i.Name).HasMaxLength(30).IsRequired();
        }
    }
}


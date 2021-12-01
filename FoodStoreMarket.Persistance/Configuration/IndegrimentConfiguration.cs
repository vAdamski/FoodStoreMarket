using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class IndegrimentConfiguration : IEntityTypeConfiguration<Indegriment>
    {
        public void Configure(EntityTypeBuilder<Indegriment> builder)
        {
            builder.Property(i => i.Name).HasMaxLength(30).IsRequired();
            builder.Property(i => i.Price).IsRequired();
        }
    }
}


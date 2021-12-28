using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class OpeningClosingHoursConfiguration : IEntityTypeConfiguration<OpeningClosingHours>
    {
        public void Configure(EntityTypeBuilder<OpeningClosingHours> builder)
        {
            builder.OwnsOne(p => p.ClosingTime);
            builder.OwnsOne(p => p.OpeningTime);

            //builder.Property(p => p.Day).HasMaxLength(15).IsRequired();
        }
    }
}


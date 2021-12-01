using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class OpeningClosingSpecificationConfiguration : IEntityTypeConfiguration<OpeningClosingSpecification>
    {
        public void Configure(EntityTypeBuilder<OpeningClosingSpecification> builder)
        {
            builder
                .HasOne(ocs => ocs.RestaurantSpecification)
                .WithOne(rs => rs.OpeningClosingSpecification)
                .HasForeignKey<RestaurantSpecification>(rs => rs.OpeningClosingSpecificationId);
        }
    }
}


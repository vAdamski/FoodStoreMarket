using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class ProductSpecificationConfiguration : IEntityTypeConfiguration<ProductSpecification>
    {
        public void Configure(EntityTypeBuilder<ProductSpecification> builder)
        {
            builder
                .HasOne(ps => ps.Product)
                .WithOne(p => p.ProductSpecification)
                .HasForeignKey<Product>(p => p.ProductSpecificationId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(ps => ps.ProductType)
                .WithMany(pt => pt.ProductSpecifications)
                .HasForeignKey(p => p.ProductTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(ps => ps.ProductSizeSpecifications)
                .WithOne(pss => pss.ProductSpecification)
                .HasForeignKey(pss => pss.ProductSpecificationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}


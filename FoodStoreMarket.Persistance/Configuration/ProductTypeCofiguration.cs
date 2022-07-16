using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class ProductTypeCofiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder
                .HasMany(pt => pt.ProductSpecifications)
                .WithOne(ps => ps.ProductType)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(pt => pt.Sizes)
                .WithOne(s => s.ProductType)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

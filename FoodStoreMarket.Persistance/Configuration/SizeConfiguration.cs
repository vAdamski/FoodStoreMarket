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
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder
                .HasMany<IngredientSizeDetail>(s => s.IngredientSizeDetails)
                .WithOne(isd => isd.Size)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder
                .HasMany<ProductSizeDetail>(s => s.ProductSizeDetails)
                .WithOne(isd => isd.Size)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

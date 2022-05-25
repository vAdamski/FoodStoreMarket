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
    public class ProductSizeConfiguration : IEntityTypeConfiguration<ComponentSizeDetails>
    {
        public void Configure(EntityTypeBuilder<ComponentSizeDetails> builder)
        {
            builder.Property(ps => ps.Price).IsRequired();
        }
    }
}

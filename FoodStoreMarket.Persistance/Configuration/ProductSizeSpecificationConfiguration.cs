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
    public class ProductSizeSpecificationConfiguration : IEntityTypeConfiguration<ProductSizeSpecification>
    {
        public void Configure(EntityTypeBuilder<ProductSizeSpecification> builder)
        {

        }
    }
}

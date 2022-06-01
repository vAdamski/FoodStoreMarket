using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration;

public class IngredientSizeDetailConfiguration : IEntityTypeConfiguration<IngredientSizeDetail>
{
    public void Configure(EntityTypeBuilder<IngredientSizeDetail> builder)
    {
        builder.
    }
}
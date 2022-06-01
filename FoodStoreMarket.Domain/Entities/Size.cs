using FoodStoreMarket.Domain.Common;
using System.Collections.Generic;

namespace FoodStoreMarket.Domain.Entities;

public class Size : AuditableEntity
{
    public int MenuId { get; set; }
    public Menu Menu { get; set; }
    public List<ProductSizeDetail> ProductSizeDetails { get; private set; } = new List<ProductSizeDetail>();
    public List<IngredientSizeDetail> IngredientSizeDetails { get; private set; } = new List<IngredientSizeDetail>();
    public string SizeName { get; set; }
}
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities;

public class IngredientSizeDetail : AuditableEntity
{
    public int MenuId { get; set; }
    public Menu Menu { get; set; }
    public int SizeId { get; set; }
    public Size Size { get; set; }
    public decimal Price { get; set; }
    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }
}
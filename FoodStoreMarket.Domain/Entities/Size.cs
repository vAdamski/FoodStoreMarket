using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities;

public class Size : AuditableEntity
{
    public int MenuId { get; set; }
    public Menu Menu { get; set; }
    public int? ComponentSizeId { get; set; }
    public ComponentSizeDetails ComponentSizeDetails { get; set; }
    public string SizeName { get; set; }
}
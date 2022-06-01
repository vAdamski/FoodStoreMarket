using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities;

public class ProductSizeDetail : AuditableEntity
{
    public int MenuId { get; set; }
    public Menu Menu { get; set; }
    public int SizeId { get; set; }
    public Size Size { get; set; }
    public decimal Price { get; set; }
    public int ProductSpecificationId { get; set; }
    public ProductSpecification ProductSpecification { get; set; }
}
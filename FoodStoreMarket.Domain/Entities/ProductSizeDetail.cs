using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities;

public class ProductSizeDetail : AuditableEntity
{
    public int SizeId { get; set; }
    public Size Size { get; set; }
    public int ProductSpecificationId { get; set; }
    public ProductSpecification ProductSpecification { get; set; }
    public decimal Price { get; set; }
}
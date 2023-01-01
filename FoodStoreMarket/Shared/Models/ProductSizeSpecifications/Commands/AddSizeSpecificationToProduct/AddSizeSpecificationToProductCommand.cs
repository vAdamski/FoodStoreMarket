using MediatR;

namespace FoodStoreMarket.Shared.Models.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct;

public class AddSizeSpecificationToProductCommand : IRequest<int>
{
    public int ProductId { get; set; }
    public int SizeId { get; set; }
    public decimal Price { get; set; }
}
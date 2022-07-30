using MediatR;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetProductType;

public class GetProductTypeQuery : IRequest<ProductTypeVm>
{
    public int ProductTypeId { get; set; }
}
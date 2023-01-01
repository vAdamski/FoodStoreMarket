using FoodStoreMarket.Shared.Models.ProductTypes.Queries.GetProductType;
using MediatR;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetProductType;

public class GetProductTypeQuery : IRequest<ProductTypeVm>
{
    public int ProductTypeId { get; set; }
}
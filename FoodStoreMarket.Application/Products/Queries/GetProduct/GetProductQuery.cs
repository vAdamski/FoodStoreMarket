using FoodStoreMarket.Shared.Models.Products.Queries.GetProduct;
using MediatR;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductQuery : IRequest<GetProductVm>
{
    public int ProductId { get; set; }
}
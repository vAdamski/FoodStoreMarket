using MediatR;

namespace FoodStoreMarket.Application.ProductTypes.Commands.DeleteProductType;

public class DeleteProductTypeCommand : IRequest
{
    public int ProductTypeId { get; set; }
}
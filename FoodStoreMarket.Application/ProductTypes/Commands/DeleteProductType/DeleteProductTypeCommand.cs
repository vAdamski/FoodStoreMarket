using MediatR;

namespace FoodStoreMarket.Application.ProductTypes.Commands.DeleteProductType;

public class DeleteProductTypeCommand : IRequest<bool>
{
    public int ProductTypeId { get; set; }
}
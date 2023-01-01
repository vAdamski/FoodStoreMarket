using MediatR;

namespace FoodStoreMarket.Shared.Models.ProductTypes.Commands.DeleteProductType;

public class DeleteProductTypeCommand : IRequest<bool>
{
    public int ProductTypeId { get; set; }
}
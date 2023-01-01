using MediatR;

namespace FoodStoreMarket.Shared.Models.ProductTypes.Commands.UpdateProductType;

public class UpdateProductTypeCommand : IRequest<int>
{
    public int ProductTypeId { get; set; }
    public string NewProductTypeName { get; set; }
}
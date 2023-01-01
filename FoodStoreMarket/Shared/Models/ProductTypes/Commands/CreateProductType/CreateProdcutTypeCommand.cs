using MediatR;

namespace FoodStoreMarket.Shared.Models.ProductTypes.Commands.CreateProductType;

public class CreateProdcutTypeCommand : IRequest<int>
{
    public int MenuId { get; set; }
    public string ProductTypeName { get; set; }
}
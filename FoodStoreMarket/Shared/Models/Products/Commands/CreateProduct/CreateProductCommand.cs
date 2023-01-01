using MediatR;

namespace FoodStoreMarket.Shared.Models.Products.Commands.CreateProduct;

public class CreateProductCommand : IRequest<int>
{
    public int MenuId { get; set; }
    public int ProductTypeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public List<int> IngredientsId { get; set; }
}
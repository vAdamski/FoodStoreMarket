using MediatR;

namespace FoodStoreMarket.Shared.Models.ProductSpecifications.Commands.UpdateProductSpecification;

public class UpdateProductSpecificationCommand : IRequest<bool>
{
    public int ProductId { get; set; }
    public int ProductTypeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<int> IngredientsId { get; set; }
}
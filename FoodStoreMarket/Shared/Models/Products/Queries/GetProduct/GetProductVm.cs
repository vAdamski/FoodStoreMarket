namespace FoodStoreMarket.Shared.Models.Products.Queries.GetProduct;

public class GetProductVm
{
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string ProductTypeName { get; set; }
    public List<GetProductIngredientDto> ProductIngredientDtos { get; } = new();
    public List<GetProductSizeDetailDto> ProductSizeDetailDtos { get; } = new();
}
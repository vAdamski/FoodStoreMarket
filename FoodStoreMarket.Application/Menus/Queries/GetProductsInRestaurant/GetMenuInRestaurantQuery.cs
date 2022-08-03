using MediatR;

namespace FoodStoreMarket.Application.Products.Queries.GetProductsInRestaurant;

public class GetMenuInRestaurantQuery : IRequest<GetMenuInRestaurantVm>
{
    public int RestaurantId { get; set; }
}
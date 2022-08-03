using MediatR;

namespace FoodStoreMarket.Application.Menus.Queries.GetProductsInRestaurant;

public class GetMenuInRestaurantQuery : IRequest<GetMenuInRestaurantVm>
{
    public int RestaurantId { get; set; }
}
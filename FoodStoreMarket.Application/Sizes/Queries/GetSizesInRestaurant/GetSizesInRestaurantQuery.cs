using FoodStoreMarket.Shared.Models.Sizes.Queries.GetSizesInRestaurant;
using MediatR;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizesInRestaurant;

public class GetSizesInRestaurantQuery : IRequest<SizesInRestaurantVm>
{
    public int RestaurantId { get; set; }
}
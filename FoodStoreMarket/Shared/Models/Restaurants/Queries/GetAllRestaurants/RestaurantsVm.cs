namespace FoodStoreMarket.Shared.Models.Restaurants.Queries.GetAllRestaurants;

public class RestaurantsVm
{
    public ICollection<RestaurantDto> Restaurants { get; set; } = new List<RestaurantDto>();
}
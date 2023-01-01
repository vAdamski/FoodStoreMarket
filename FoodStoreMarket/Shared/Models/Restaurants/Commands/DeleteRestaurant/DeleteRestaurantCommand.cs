using MediatR;

namespace FoodStoreMarket.Shared.Models.Restaurants.Commands.DeleteRestaurant;

public class DeleteRestaurantCommand : IRequest
{
    public int IdRestaurantToDelete { get; set; }
}
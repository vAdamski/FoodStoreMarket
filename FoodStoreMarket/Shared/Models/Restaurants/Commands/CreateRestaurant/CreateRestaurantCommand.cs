using MediatR;

namespace FoodStoreMarket.Shared.Models.Restaurants.Commands.CreateRestaurant;

public class CreateRestaurantCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string City { get; set; }
    public string PostCode { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string FlatNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}
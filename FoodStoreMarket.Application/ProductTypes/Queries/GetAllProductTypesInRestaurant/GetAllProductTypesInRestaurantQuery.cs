using MediatR;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant;

public class GetAllProductTypesInRestaurantQuery : IRequest<GetAllProductTypesInRestaurantVm>
{
    public int RestaurantId { get; set; }
}
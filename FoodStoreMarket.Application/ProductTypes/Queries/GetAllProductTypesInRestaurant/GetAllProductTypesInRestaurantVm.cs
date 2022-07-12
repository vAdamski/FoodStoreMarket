using System.Collections.Generic;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant;

public class GetAllProductTypesInRestaurantVm
{
    public List<GetAllProductTypesInRestaurantDto> GetAllProductTypesInRestaurantDtos { get; set; } =
        new List<GetAllProductTypesInRestaurantDto>();
}
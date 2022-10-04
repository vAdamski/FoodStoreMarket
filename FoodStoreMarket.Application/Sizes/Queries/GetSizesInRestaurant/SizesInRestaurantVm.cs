using System.Collections.Generic;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizesInRestaurant;

public class SizesInRestaurantVm
{
    public List<SizeInRestaurantDto> SizeInMenuDtos { get; set; } = new List<SizeInRestaurantDto>();
}
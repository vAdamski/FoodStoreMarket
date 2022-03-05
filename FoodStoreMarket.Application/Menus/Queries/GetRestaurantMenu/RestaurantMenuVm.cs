using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Menus.Queries.GetRestaurantMenu
{
    public class RestaurantMenuVm
    {
        public ICollection<RestaurantProductDto> restaurantProductDtos { get; set; } = new List<RestaurantProductDto>();
    }
}

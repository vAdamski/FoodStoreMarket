using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Shared.Models.Restaurant.Queries.GetAllRestaurants
{
    public class RestaurantsVm
    {
        public ICollection<RestaurantDto> Restaurants { get; set; } = new List<RestaurantDto>();
    }
}

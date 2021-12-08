using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants
{
    public class RestaurantsVm
    {
        public ICollection<RestaurantDto> Restaurants { get; set; }
    }
}

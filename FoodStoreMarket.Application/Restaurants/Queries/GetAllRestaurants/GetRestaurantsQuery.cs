using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Restaurants.Queries.GetAllRestaurants;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants
{
    public class GetRestaurantsQuery : IRequest<RestaurantsVm>
    {

    }
}

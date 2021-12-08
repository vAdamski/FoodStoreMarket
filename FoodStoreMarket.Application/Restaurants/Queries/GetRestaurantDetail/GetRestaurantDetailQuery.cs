using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailQuery : IRequest<RestaurantDetailVm>
    {
        public int RestaurantId { get; set; }
    }
}

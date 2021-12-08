using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants
{
    public class RestaurantsQueryHandler : IRequestHandler<RestaurantsQuery, RestaurantsVm>
    {
        private readonly IFoodStoreMarketDbContext _context;
        public RestaurantsQueryHandler(IFoodStoreMarketDbContext foodStoreMarketDbContext)
        {
            _context = foodStoreMarketDbContext;
        }
        public async Task<RestaurantsVm> Handle(RestaurantsQuery request, CancellationToken cancellationToken)
        {
            var restuatrants = _context.Restaurants;

            var restaurantsVm = new RestaurantsVm()
            {
                //Restaurants = restuatrants,
            };

            return restaurantsVm;
        }
    }
}

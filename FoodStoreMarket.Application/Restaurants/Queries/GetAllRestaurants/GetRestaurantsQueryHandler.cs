using AutoMapper;
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
    public class GetRestaurantsQueryHandler : IRequestHandler<GetRestaurantsQuery, RestaurantsVm>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public GetRestaurantsQueryHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext,
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }
        public async Task<RestaurantsVm> Handle(GetRestaurantsQuery request, CancellationToken cancellationToken)
        {
            var restuatrants = _context.Restaurants.Select(x => x).ToList();

            var restaurantsVm = new RestaurantsVm();

            restuatrants.ForEach(r =>
            {
                r.RestaurantSpecification = _context.RestaurantSpecifications.Where(rs => rs.RestaurantId == rs.Id).FirstOrDefault();

                var restaurant = _mapper.Map<RestaurantDto>(r);

                restaurantsVm.Restaurants.Add(restaurant);
            });

            return restaurantsVm;
        }
    }
}

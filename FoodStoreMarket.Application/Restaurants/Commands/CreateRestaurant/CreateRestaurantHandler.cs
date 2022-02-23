using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants;
using FoodStoreMarket.Domain.Entities;
using AutoMapper;

namespace FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantHandler : IRequestHandler<CreateRestaurantCommand, int>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public CreateRestaurantHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext, 
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurant = new Restaurant();
            _context.Restaurants.Add(restaurant);

            await _context.SaveChangesAsync(cancellationToken);

            //RestaurantSpecification restaurantSpecification = MapRestaurantSpecifiaction(request);
            RestaurantSpecification restaurantSpecification = _mapper.Map<RestaurantSpecification>(request);
            restaurantSpecification.RestaurantId = restaurant.Id;
            _context.RestaurantSpecifications.Add(restaurantSpecification);

            Menu menu = new Menu();
            menu.RestaurantId = restaurant.Id;
            _context.Menus.Add(menu);

            await _context.SaveChangesAsync(cancellationToken);
            
            return restaurant.Id;
        }

        private RestaurantSpecification MapRestaurantSpecifiaction(CreateRestaurantCommand request)
        {
            var restauranSpecification = new RestaurantSpecification();
            restauranSpecification.Adres = new Domain.ValueObjects.Adres();
            restauranSpecification.Description = request.Description;
            restauranSpecification.Name = request.Name;
            restauranSpecification.Adres.City = request.City;
            restauranSpecification.Adres.PostCode = request.PostCode;
            restauranSpecification.Adres.Street = request.Street;
            restauranSpecification.Adres.HouseNumber = request.HouseNumber;
            restauranSpecification.Adres.FlatNumber = request.FlatNumber;
            restauranSpecification.Adres.Email = request.Email;
            restauranSpecification.Adres.PhoneNumber = request.PhoneNumber;

            return restauranSpecification;
        }
    }
}

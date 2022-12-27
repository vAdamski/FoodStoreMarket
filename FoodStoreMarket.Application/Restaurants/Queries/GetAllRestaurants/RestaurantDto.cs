using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants
{
    public class RestaurantDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

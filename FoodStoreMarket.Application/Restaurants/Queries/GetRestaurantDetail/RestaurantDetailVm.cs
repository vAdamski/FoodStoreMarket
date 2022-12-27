using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail
{
    public class RestaurantDetailVm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

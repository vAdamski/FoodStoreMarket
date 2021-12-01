using System;
using FoodStoreMarket.Application.Interfaces;

namespace FoodStoreMarket.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}


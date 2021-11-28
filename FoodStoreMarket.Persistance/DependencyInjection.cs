﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStoreMarket.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FoodStoreMarketDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("FoodStoreMarketDatabase")));

            return services;
        }
    }
}

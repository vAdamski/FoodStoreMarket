using System;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Persistance
{
    public class FoodStoreMarketDbContextFactory : DesignTimeDbContextFactoryBase<FoodStoreMarketDbContext>
    {
        protected override FoodStoreMarketDbContext CreateNewInstance(DbContextOptions<FoodStoreMarketDbContext> options)
        {
            return new FoodStoreMarketDbContext(options);
        }
    }
}

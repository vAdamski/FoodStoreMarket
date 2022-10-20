using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Persistance;

namespace Application.UnitTests.Common;

public class QueryTestFixtures : IDisposable
{
    public FoodStoreMarketDbContext Context { get; private set; }
    public IMapper Mapper { get; private set; }

    public QueryTestFixtures()
    {
        Context = FoodStoreMarketDbContextFactory.Create().Object;
        
        var configurationProvider = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<MappingProfile>();
        });

        Mapper = configurationProvider.CreateMapper();
    }

    public void Dispose()
    {
        FoodStoreMarketDbContextFactory.Destory(Context);
    }
    
    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixtures> { }
}
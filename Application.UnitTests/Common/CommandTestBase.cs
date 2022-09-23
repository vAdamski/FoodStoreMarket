using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Persistance;
using Moq;

namespace Application.UnitTests.Common;

public class CommandTestBase : IDisposable
{
    protected readonly FoodStoreMarketDbContext _context;
    protected readonly Mock<FoodStoreMarketDbContext> _contextMock;
    
    public CommandTestBase()
    {
        _contextMock = FoodStoreMarketDbContextFactory.Create();
        _context = _contextMock.Object;
    }
    
    public void Dispose()
    {
        FoodStoreMarketDbContextFactory.Destory(_context);
    }
}
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Persistance;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Application.UnitTests.Common;

public static class FoodStoreMarketDbContextFactory
{
    public static Mock<FoodStoreMarketDbContext> Create()
    {
        var dateTime = new DateTime(2022, 9, 15);
        var dateTimeMock = new Mock<IDateTime>();
        dateTimeMock.Setup(m => m.Now).Returns(dateTime);

        var currentUserMock = new Mock<ICurrentUserService>();
        currentUserMock.Setup(m => m.Email).Returns("test@test.com");
        currentUserMock.Setup(m => m.IsAuthenticated).Returns(true);

        // var currentUserService = new ICurrentUserService
        // {
        //     Email = "TEST@EMAIL.COM", 
        //     IsAuthenticated = true
        // };

        var options = new DbContextOptionsBuilder<FoodStoreMarketDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

        var mock = new Mock<FoodStoreMarketDbContext>(options, dateTimeMock.Object, currentUserMock.Object)
            { CallBase = true };

        var context = mock.Object;

        context.Database.EnsureCreated();

        // context.SeedData();
        
        //Save changes

        return mock;
    }

    public static void Destory(FoodStoreMarketDbContext context)
    {
        context.Database.EnsureDeleted();
        context.Dispose();
    }
}
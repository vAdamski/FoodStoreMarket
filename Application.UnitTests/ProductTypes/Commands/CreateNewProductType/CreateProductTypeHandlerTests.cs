using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;

namespace Application.UnitTests.ProductTypes.Commands.CreateNewProductType;

public class CreateProductTypeHandlerTests : CommandTestBase, IClassFixture<CommandTestFixture>
{
    private readonly CreateProductTypeCommandHandler _handler;

    public CreateProductTypeHandlerTests(CommandTestFixture fixture) : base()
    {
        _handler = new CreateProductTypeCommandHandler(_context, fixture.Mapper);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertProductType()
    {
    }
}
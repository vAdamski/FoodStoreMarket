using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;

namespace Application.UnitTests.ProductTypes.Commands.CreateNewProductType;

public class CreateProductTypeHandlerTests : CommandTestBase
{
    private readonly CreateProductTypeCommandHandler _handler;

    public CreateProductTypeHandlerTests() : base()
    {
        _handler = new CreateProductTypeCommandHandler(_context, _mapper);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertProductType()
    {
    }
}
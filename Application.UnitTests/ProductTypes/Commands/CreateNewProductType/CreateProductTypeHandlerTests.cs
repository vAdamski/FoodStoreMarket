using Application.UnitTests.Common;
using FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;

namespace Application.UnitTests.ProductTypes.Commands.CreateNewProductType;

public class CreateProductTypeHandlerTests : CommandTestBase
{
    private readonly Create _handler;

    public CreateProductTypeHandlerTests() : base()
    {
        _handler = new CreateProductTypeHandler(_context);
    }
}
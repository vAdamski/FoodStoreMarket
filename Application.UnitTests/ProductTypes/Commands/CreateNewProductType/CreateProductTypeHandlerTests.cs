using Application.UnitTests.Common;
using FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;

namespace Application.UnitTests.ProductTypes.Commands.CreateNewProductType;

public class CreateProductTypeHandlerTests : CommandTestBase
{
    private readonly CreateProductTypeHandler _handler;

    public CreateProductTypeHandlerTests() : base()
    {
        _handler = new AddNewProductTypeHandler(_context);
    }
}
using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;
using FoodStoreMarket.Common;
using Microsoft.EntityFrameworkCore;
using Shouldly;

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
        var command = new CreateProdcutTypeCommand()
        {
            MenuId = 1,
            ProductTypeName = "Snacks"
        };

        var createdProductTypeId = await _handler.Handle(command, CancellationToken.None);

        var productType = await _context.ProductTypes.FirstOrDefaultAsync(x => x.Id == createdProductTypeId);

        productType.ShouldNotBeNull();
        productType.MenuId.ShouldBe(1);
        productType.ProductTypeName.ShouldBe("Snacks");
    }

    [Fact]
    public async Task Handle_GivenNotExistingMenuId_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateProdcutTypeCommand()
            {
                MenuId = 5,
                ProductTypeName = "Snacks"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var response = _context.ProductTypes.FirstOrDefaultAsync(x => x.Id == result, CancellationToken.None);
            
            response.ShouldBeNull();
        }
        catch (Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
}
using FluentValidation;

namespace FoodStoreMarket.Application.ProductTypes.Commands.AddNewProductType;

public class AddNewProductTypeCommandValidator : AbstractValidator<AddNewProdcutTypeCommand>
{
    public AddNewProductTypeCommandValidator()
    {
        RuleFor(x => x.MenuId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeName).NotEmpty().MinimumLength(1).MaximumLength(20);
    }
}
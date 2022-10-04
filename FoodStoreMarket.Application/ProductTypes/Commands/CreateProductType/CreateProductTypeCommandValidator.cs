using FluentValidation;

namespace FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;

public class CreateProductTypeCommandValidator : AbstractValidator<CreateProdcutTypeCommand>
{
    public CreateProductTypeCommandValidator()
    {
        RuleFor(x => x.MenuId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeName).NotEmpty().MinimumLength(1).MaximumLength(20);
    }
}
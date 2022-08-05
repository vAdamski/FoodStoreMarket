using FluentValidation;

namespace FoodStoreMarket.Application.Products.Commands.AddNewProduct;

public class AddNewProductCommandValidator : AbstractValidator<AddNewProductCommand>
{
    public AddNewProductCommandValidator()
    {
        RuleFor(x => x.MenuId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty().MaximumLength(25);
        RuleFor(x => x.Description).MaximumLength(255);
    }
}
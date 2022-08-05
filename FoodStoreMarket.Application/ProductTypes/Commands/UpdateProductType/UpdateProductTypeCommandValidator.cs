using FluentValidation;

namespace FoodStoreMarket.Application.ProductTypes.Commands.UpdateProductType;

public class UpdateProductTypeCommandValidator : AbstractValidator<UpdateProductTypeCommand>
{
    public UpdateProductTypeCommandValidator()
    {
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.NewProductTypeName).NotEmpty().MinimumLength(1).MaximumLength(20);
    }
}
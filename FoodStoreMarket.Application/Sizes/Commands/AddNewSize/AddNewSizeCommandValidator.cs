using FluentValidation;

namespace FoodStoreMarket.Application.Sizes.Commands.AddNewSize;

public class AddNewSizeCommandValidator : AbstractValidator<AddNewSizeCommand>
{
    public AddNewSizeCommandValidator()
    {
        RuleFor(x => x.MenuId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.SizeName).NotEmpty().MinimumLength(1).MaximumLength(20);
    }
}
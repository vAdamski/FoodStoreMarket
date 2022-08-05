using FluentValidation;

namespace FoodStoreMarket.Application.Sizes.Commands.EditSize;

public class EditSizeCommandValidator : AbstractValidator<EditSizeCommand>
{
    public EditSizeCommandValidator()
    {
        RuleFor(x => x.SizeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.SizeName).NotEmpty().MinimumLength(1).MaximumLength(20);
    }
}
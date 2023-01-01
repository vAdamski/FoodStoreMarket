using FluentValidation;
using FoodStoreMarket.Shared.Models.Sizes.Commands.UpdateSize;

namespace FoodStoreMarket.Application.Sizes.Commands.UpdateSize;

public class UpdateSizeCommandValidator : AbstractValidator<UpdateSizeCommand>
{
    public UpdateSizeCommandValidator()
    {
        RuleFor(x => x.SizeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.SizeName).NotEmpty().MinimumLength(1).MaximumLength(20);
    }
}
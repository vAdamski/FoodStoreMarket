using FluentValidation;
using FoodStoreMarket.Shared.Models.Sizes.Commands.CreateSize;

namespace FoodStoreMarket.Application.Sizes.Commands.CreateSize;

public class CreateSizeCommandValidator : AbstractValidator<CreateSizeCommand>
{
    public CreateSizeCommandValidator()
    {
        RuleFor(x => x.MenuId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.SizeName).NotEmpty().MinimumLength(1).MaximumLength(20);
    }
}
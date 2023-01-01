using FluentValidation;
using FoodStoreMarket.Shared.Models.Sizes.Commands.DeleteSize;

namespace FoodStoreMarket.Application.Sizes.Commands.DeleteSize;

public class DeleteSizeCommandValidator : AbstractValidator<DeleteSizeCommand>
{
    public DeleteSizeCommandValidator()
    {
        RuleFor(x => x.SizeIdToDelete).NotEmpty().GreaterThan(0);
    }
}
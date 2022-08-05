using FluentValidation;

namespace FoodStoreMarket.Application.Sizes.Commands.DeleteSize;

public class DeleteSizeCommandValidator : AbstractValidator<DeleteSizeCommand>
{
    public DeleteSizeCommandValidator()
    {
        RuleFor(x => x.SizeIdToDelete).NotEmpty().GreaterThan(0);
    }
}
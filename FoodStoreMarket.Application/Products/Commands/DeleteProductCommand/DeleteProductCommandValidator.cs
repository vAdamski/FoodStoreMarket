using FluentValidation;

namespace FoodStoreMarket.Application.Products.Commands.DeleteProductCommand;

public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty().GreaterThan(0);
    }
}

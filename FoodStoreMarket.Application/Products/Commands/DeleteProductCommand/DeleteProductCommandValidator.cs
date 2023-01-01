using FluentValidation;
using FoodStoreMarket.Shared.Models.Products.Commands.DeleteProductCommand;

namespace FoodStoreMarket.Application.Products.Commands.DeleteProductCommand;

public class DeleteProductCommandValidator : AbstractValidator<Shared.Models.Products.Commands.DeleteProductCommand.DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty().GreaterThan(0);
    }
}

using FluentValidation;

namespace FoodStoreMarket.Application.ProductTypes.Commands.DeleteProductType;

public class DeleteProductTypeCommandValidator : AbstractValidator<DeleteProductTypeCommand>
{
    public DeleteProductTypeCommandValidator()
    {
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
    }
}
using FluentValidation;

namespace FoodStoreMarket.Application.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct;

public class AddSizeSpecificationToProductCommandValidator : AbstractValidator<AddSizeSpecificationToProductCommand>
{
    public AddSizeSpecificationToProductCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.SizeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Price).NotEmpty().GreaterThanOrEqualTo(0);
    }
}
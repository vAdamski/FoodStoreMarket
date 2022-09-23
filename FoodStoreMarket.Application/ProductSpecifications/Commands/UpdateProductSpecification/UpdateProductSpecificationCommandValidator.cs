using FluentValidation;

namespace FoodStoreMarket.Application.ProductSpecifications.Commands.UpdateProductSpecification;

public class UpdateProductSpecificationCommandValidator : AbstractValidator<UpdateProductSpecificationCommand>
{
    public UpdateProductSpecificationCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty().MaximumLength(25);
        RuleFor(x => x.Description).MaximumLength(255);
    }
}
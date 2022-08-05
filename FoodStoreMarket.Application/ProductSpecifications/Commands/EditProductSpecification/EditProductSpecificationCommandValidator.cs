using FluentValidation;

namespace FoodStoreMarket.Application.ProductSpecifications.Commands.EditProductSpecification;

public class EditProductSpecificationCommandValidator : AbstractValidator<EditProductSpecificationCommand>
{
    public EditProductSpecificationCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ProductTypeId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty().MaximumLength(25);
        RuleFor(x => x.Description).MaximumLength(255);
    }
}
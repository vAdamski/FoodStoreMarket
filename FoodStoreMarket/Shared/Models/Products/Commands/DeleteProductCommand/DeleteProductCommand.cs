using MediatR;

namespace FoodStoreMarket.Shared.Models.Products.Commands.DeleteProductCommand;

public class DeleteProductCommand : IRequest<bool>
{
    public int ProductId { get; set; }
}
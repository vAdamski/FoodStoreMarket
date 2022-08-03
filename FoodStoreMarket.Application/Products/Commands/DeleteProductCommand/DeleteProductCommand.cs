using MediatR;

namespace FoodStoreMarket.Application.Products.Commands.DeleteProductCommand;

public class DeleteProductCommand : IRequest<bool>
{
    public int ProductId { get; set; }
}
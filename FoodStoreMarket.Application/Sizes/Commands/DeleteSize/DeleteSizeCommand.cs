using MediatR;

namespace FoodStoreMarket.Application.Sizes.Commands.DeleteSize;

public class DeleteSizeCommand : IRequest
{
    public int SizeIdToDelete { get; set; }
}
using MediatR;

namespace FoodStoreMarket.Shared.Models.Sizes.Commands.DeleteSize;

public class DeleteSizeCommand : IRequest
{
    public int SizeIdToDelete { get; set; }
}
using MediatR;

namespace FoodStoreMarket.Shared.Models.Sizes.Commands.UpdateSize;

public class UpdateSizeCommand : IRequest<int>
{
    public int SizeId { get; set; }
    public int ProductTypeId { get; set; }
    public string SizeName { get; set; }
}
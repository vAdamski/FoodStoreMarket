using MediatR;

namespace FoodStoreMarket.Application.Sizes.Commands.UpdateSize;

public class UpdateSizeCommand : IRequest<int>
{
    public int SizeId { get; set; }
    public int ProductTypeId { get; set; }
    public string SizeName { get; set; }
}
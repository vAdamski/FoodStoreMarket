using MediatR;

namespace FoodStoreMarket.Application.Sizes.Commands.CreateSize;

public class CreateSizeCommand : IRequest<int>
{
    public string SizeName { get; set; }
    public int MenuId { get; set; }
    public int ProductTypeId { get; set; }
}
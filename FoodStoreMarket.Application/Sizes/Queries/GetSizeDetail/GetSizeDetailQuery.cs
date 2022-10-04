using MediatR;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizeDetail;

public class GetSizeDetailQuery : IRequest<SizeDetailVm>
{
    public int SizeId { get; set; }
}
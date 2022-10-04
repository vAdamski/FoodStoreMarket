using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct;

public class AddSizeSpecificationToProductCommand : IRequest<int>, IMapFrom<AddSizeSpecificationToProductCommand>
{
    public int ProductId { get; set; }
    public int SizeId { get; set; }
    public decimal Price { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<AddSizeSpecificationToProductCommand, ProductSizeSpecification>()
            .ForMember(x => x.SizeId, map => map.MapFrom(src => src.SizeId))
            .ForMember(x => x.Price, map => map.MapFrom(src => src.Price))
            .IgnoreAllNonExisting();
    }
}
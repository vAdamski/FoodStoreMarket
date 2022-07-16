using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Sizes.Commands.EditSize;

public class EditSizeCommand : IRequest<int>, IMapFrom<EditSizeCommand>
{
    public int SizeId { get; set; }
    public int ProductTypeId { get; set; }
    public string SizeName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<EditSizeCommand, Size>()
            .ForMember(x => x.SizeName, map => map.MapFrom(src => src.SizeName))
            .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId));
    }
}
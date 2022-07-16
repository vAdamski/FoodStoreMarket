using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Sizes.Commands.AddNewSize;

public class AddNewSizeCommand : IRequest<int>, IMapFrom<AddNewSizeCommand>
{
    public string SizeName { get; set; }
    public int MenuId { get; set; }
    public int ProductTypeId { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<AddNewSizeCommand, Size>()
            .ForMember(x => x.SizeName, map => map.MapFrom(src => src.SizeName))
            .ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId))
            .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId));
    }
}
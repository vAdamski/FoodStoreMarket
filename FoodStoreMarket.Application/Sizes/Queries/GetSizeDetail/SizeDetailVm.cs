using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizeDetail;

public class SizeDetailVm : IMapFrom<Size>
{
    public int Id { get; set; }
    public string SizeName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Size, SizeDetailVm>()
            .ForMember(x => x.Id, map => map.MapFrom(src => src.Id))
            .ForMember(x => x.SizeName, map => map.MapFrom(src => src.SizeName));
    }
}
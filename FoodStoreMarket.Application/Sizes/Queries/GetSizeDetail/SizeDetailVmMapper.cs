using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Sizes.Queries.GetSizeDetail;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizeDetail
{
    public class SizeDetailVmMapper : IMapFrom<Size>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Size, SizeDetailVm>()
                .ForMember(x => x.Id, map => map.MapFrom(src => src.Id))
                .ForMember(x => x.SizeName, map => map.MapFrom(src => src.SizeName));
        }
    }
}

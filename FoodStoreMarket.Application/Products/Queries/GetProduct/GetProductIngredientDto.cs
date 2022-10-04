using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductIngredientDto : IMapFrom<Ingredient>
{
    public string IngredientId { get; set; }
    public string IngredientName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Ingredient, GetProductIngredientDto>()
            .ForMember(x => x.IngredientId, map => map.MapFrom(src => src.Id))
            .ForMember(x => x.IngredientName, map => map.MapFrom(src => src.Name));
    }
}
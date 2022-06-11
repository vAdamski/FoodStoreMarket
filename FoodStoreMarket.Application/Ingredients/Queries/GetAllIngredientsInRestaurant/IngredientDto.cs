using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetAllIngredientsInRestaurant;

public class IngredientDto : IMapFrom<Ingredient>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Ingredient, IngredientDto>()
            .ForMember(x => x.Name, map => map.MapFrom(src => src.Name));
    }
}
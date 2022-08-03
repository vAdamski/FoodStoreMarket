using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProductsInRestaurant;

public class GetMenuInRestaurantProductIngredientsDto : IMapFrom<Ingredient>
{
    public string IngredientName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Ingredient, GetMenuInRestaurantProductIngredientsDto>()
            .ForMember(x => x.IngredientName, map => map.MapFrom(src => src.Name));
    }
}
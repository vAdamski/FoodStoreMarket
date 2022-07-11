using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetAllIngredientsInRestaurant;

public class GetAllIngredientsInRestaurantQueryHandler : IRequestHandler<GetAllIngredientsInRestaurantQuery, IngredientsInRestaurantVm>
{
    private readonly IFoodStoreMarketDbContext _context;
    private IMapper _mapper;
    
    public GetAllIngredientsInRestaurantQueryHandler(
        IFoodStoreMarketDbContext foodStoreMarketDbContext,
        IMapper mapper)
    {
        _context = foodStoreMarketDbContext;
        _mapper = mapper;
    }
    
    public async Task<IngredientsInRestaurantVm> Handle(GetAllIngredientsInRestaurantQuery request, CancellationToken cancellationToken)
    {
        var ingredientsInRestaurant =
            await _context.Ingredients.Where(i => i.MenuId == request.MenuId && i.StatusId == 1).ToListAsync(cancellationToken);

        var ingredientsVm = new IngredientsInRestaurantVm();

        ingredientsInRestaurant.ForEach(i =>
        {
            ingredientsVm.IngredientDtos.Add(_mapper.Map<Ingredient,IngredientDto>(i));
        });

        return ingredientsVm;
    }
}
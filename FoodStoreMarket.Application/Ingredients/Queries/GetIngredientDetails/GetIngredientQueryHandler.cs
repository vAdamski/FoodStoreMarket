using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Shared.Models.Ingredients.Queries.GetIngredientDetails;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetIngredientDetails;

public class GetIngredientQueryHandler : IRequestHandler<GetIngredientQuery, IngredientVm>
{
    private readonly IFoodStoreMarketDbContext _context;
    private IMapper _mapper;
    
    public GetIngredientQueryHandler(
        IFoodStoreMarketDbContext foodStoreMarketDbContext,
        IMapper mapper)
    {
        _context = foodStoreMarketDbContext;
        _mapper = mapper;
    }
    
    public async Task<IngredientVm> Handle(GetIngredientQuery request, CancellationToken cancellationToken)
    {
        var ingredient = await _context.Ingredients.Where(i => i.Id == request.IngredientId)
            .FirstOrDefaultAsync(cancellationToken);
        
        var ingredientVm = _mapper.Map<Ingredient, IngredientVm>(ingredient);
        
        return ingredientVm;
    }
}
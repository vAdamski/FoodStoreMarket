using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Ingredients.Commands.UpdateIngredient;

public class UpdateIngredientCommandHandler : IRequestHandler<UpdateIngredientCommand, bool>
{
    private readonly IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public UpdateIngredientCommandHandler(
        IFoodStoreMarketDbContext foodStoreMarketDbContext,
        IMapper mapper)
    {
        _context = foodStoreMarketDbContext;
        _mapper = mapper;
    }
    public async Task<bool> Handle(UpdateIngredientCommand request, CancellationToken cancellationToken)
    {
        var ingredientToEdit =
            await _context.Ingredients.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

        if (ingredientToEdit is not null)
        {
            ingredientToEdit.Name = request.Name;

            _context.Ingredients.Update(ingredientToEdit);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }

        return false;
    }
}
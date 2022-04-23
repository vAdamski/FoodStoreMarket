using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Ingredients.Commands.EditIngredient;

public class EditIngredientHandler : IRequestHandler<EditIngredientCommand, bool>
{
    private readonly IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public EditIngredientHandler(
        IFoodStoreMarketDbContext foodStoreMarketDbContext,
        IMapper mapper)
    {
        _context = foodStoreMarketDbContext;
        _mapper = mapper;
    }
    public async Task<bool> Handle(EditIngredientCommand request, CancellationToken cancellationToken)
    {
        var ingredientToEdit =
            await _context.Ingredients.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

        if (ingredientToEdit is not null)
        {
            ingredientToEdit.Name = request.Name;
            ingredientToEdit.Price = request.Price;

            _context.Ingredients.Update(ingredientToEdit);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }

        return false;
    }
}
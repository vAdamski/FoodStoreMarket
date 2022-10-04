using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Ingredients.Commands.DeleteIngredient
{
	public class DeleteIngredientCommandHandler : IRequestHandler<DeleteIngredientCommand>
	{
        private readonly IFoodStoreMarketDbContext _context;
        public DeleteIngredientCommandHandler(IFoodStoreMarketDbContext foodStoreMarketDbContext)
        {
            _context = foodStoreMarketDbContext;
        }

        public async Task<Unit> Handle(DeleteIngredientCommand request, CancellationToken cancellationToken)
        {
            var ingredientToDelete = await _context.Ingredients.Where(i => i.Id == request.IngredientIdToDelete).FirstOrDefaultAsync(cancellationToken);

            _context.Ingredients.Remove(ingredientToDelete);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}


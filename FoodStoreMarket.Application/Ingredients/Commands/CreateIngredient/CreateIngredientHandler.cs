using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Ingredients.Commands.CreateIndegriment
{
    public class CreateIngredientHandler : IRequestHandler<CreateIngredientCommand, int>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public CreateIngredientHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext,
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateIngredientCommand request, CancellationToken cancellationToken)
        {
            var menuIsExist = await _context.Menus.Where(m => m.Id == request.MenuId)
                .FirstOrDefaultAsync(cancellationToken);
            var sizesInMenu = await _context.Sizes.Where(s => s.MenuId == request.MenuId)
                .ToListAsync(cancellationToken);

            //Create base for ingredient
            var ingredientToAdd = _mapper.Map<Ingredient>(request);
            
            //Create all available sizes for new ingredient
            sizesInMenu.ForEach(s =>
            {
                var newIngredientSizeDetails = new IngredientSizeDetail();
                newIngredientSizeDetails.SizeId = s.Id;
            });

            await _context.Ingredients.AddAsync(ingredientToAdd, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return ingredientToAdd.Id;
        }
    }
}


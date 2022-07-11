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
            //Create base for ingredient
            var ingredientToAdd = _mapper.Map<Ingredient>(request);
            
            //Save new ingredient to get ID for next step
            await _context.Ingredients.AddAsync(ingredientToAdd, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            //Next actions for create ingredient
            

            return ingredientToAdd.Id;
        }
    }
}


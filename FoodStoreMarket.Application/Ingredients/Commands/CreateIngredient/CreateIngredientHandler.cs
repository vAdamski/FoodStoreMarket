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
            var menuIsExist = await _context.Menus.Where(m => m.Id == request.MenuId).FirstOrDefaultAsync(cancellationToken);
            var sizesInMenu = await _context.

            var indegrimentToAdd = _mapper.Map<Ingredient>(request);
            await _context.Ingredients.AddAsync(indegrimentToAdd, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return indegrimentToAdd.Id;
        }
    }
}


﻿using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Menus.Queries.GetRestaurantMenu
{
    internal class GetRestaurantMenuQueryHandler : IRequestHandler<GetRestaurantMenuQuery, RestaurantMenuVm>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public GetRestaurantMenuQueryHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext,
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }

        public async Task<RestaurantMenuVm> Handle(GetRestaurantMenuQuery request, CancellationToken cancellationToken)
        {
            Menu menu = await _context.Menus.Where(m => m.Id == request.IdRestuarantMenu).FirstOrDefaultAsync(cancellationToken);

            if(menu != null)
            {
                var productList = await _context.Products.Where(p => p.MenuId == request.IdRestuarantMenu).ToListAsync(cancellationToken);

                productList.ForEach(p =>
                {
                    p.ProductSpecification = _context.ProductSpecifications.Where(ps => ps.ProductId == p.Id).FirstOrDefault();
                });
            }

            var vm = new RestaurantMenuVm();

            menu.Products.ForEach(p =>
            {
                var productVm = _mapper.Map<RestaurantProductDto>(p.ProductSpecification);

                p.ProductSpecification.Indegriments.ForEach(i =>
                {
                    var indegrimentDto = _mapper.Map<ProductIndegrimentDto>(i);

                    productVm.IndegrimentsDto.Add(indegrimentDto);
                });

                vm.restaurantProductDtos.Add(productVm);
            });

            return vm;
        }
    }
}

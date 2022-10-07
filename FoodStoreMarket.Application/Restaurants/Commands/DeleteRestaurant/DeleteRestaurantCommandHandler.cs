using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant
{
    public class DeleteRestaurantCommandHandler : IRequestHandler<DeleteRestaurantCommand>
    {
        private readonly IFoodStoreMarketDbContext _context;
        public DeleteRestaurantCommandHandler(IFoodStoreMarketDbContext foodStoreMarketDbContext)
        {
            _context = foodStoreMarketDbContext;
        }

        public async Task<Unit> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurantData = await GetAllRestaurantData(request.IdRestaurantToDelete, cancellationToken);

            DeleteRestaurantData(restaurantData);

            return Unit.Value;
        }

        private async Task<Restaurant> GetAllRestaurantData(int restaurantId, CancellationToken cancellationToken)
        {
            var data = await _context.Restaurants
                .Where(r => r.Id == restaurantId)
                .Include(r => r.Menu)
                .ThenInclude(m => m.Products)
                .ThenInclude(p => p.ProductSpecification)
                .ThenInclude(ps => ps.ProductSizeSpecifications)
                .ThenInclude(pss => pss.Size)
                .Include(r => r.Menu)
                .ThenInclude(m => m.Ingredients)
                .Include(r => r.Menu)
                .ThenInclude(m => m.ProductTypes)
                .Include(r => r.RestaurantSpecification)
                .ThenInclude(rs => rs.OpeningClosingSpecification)
                .ThenInclude(ocs => ocs.OpeningClosingHours)
                .Include(r => r.RestaurantSpecification)
                .ThenInclude(rs => rs.Employees)
                .ThenInclude(e => e.WorkingHours)
                .FirstOrDefaultAsync(cancellationToken);

            return data;
        }

        private void DeleteRestaurantData(Restaurant restaurant)
        {
            RestaurantDelete(restaurant);
            MenuDelete(restaurant.Menu);
            ProductsDelete(restaurant.Menu.Products);

            var productsSpec = restaurant.Menu.Products.Select(x => x.ProductSpecification).ToList();
            ProductsSpecDelete(productsSpec);

            var ingredients = restaurant.Menu.Ingredients;
            IngredientsDelete(ingredients);

            var productTypes = restaurant.Menu.ProductTypes;
            ProductTypesDelete(productTypes);

            var sizes = restaurant.Menu.Sizes;
            SizesDelete(sizes);

            var productSizeSpec = new List<ProductSizeSpecification>();

            sizes.ForEach(s =>
            {
                productSizeSpec.AddRange(s.ProductSizeSpecifications);
            });

            ProductSizeSpecificationDelete(productSizeSpec);


        }

        private void RestaurantDelete(Restaurant restaurant)
        {
            _context.Restaurants.Remove(restaurant);
        }

        private void MenuDelete(Menu menu)
        {
            _context.Menus.Remove(menu);
        }

        private void ProductsDelete(List<Product> products)
        {
            _context.Products.RemoveRange(products);
        }

        private void ProductsSpecDelete(List<ProductSpecification> productsSpec)
        {
            _context.ProductSpecifications.RemoveRange(productsSpec);
        }

        private void IngredientsDelete(List<Ingredient> ingredients)
        {
            _context.Ingredients.RemoveRange(ingredients);
        }

        private void ProductTypesDelete(List<ProductType> productTypes)
        {
            _context.ProductTypes.RemoveRange(productTypes);
        }

        private void SizesDelete(List<Size> sizes)
        {
            _context.Sizes.RemoveRange(sizes);
        }

        private void ProductSizeSpecificationDelete(List<ProductSizeSpecification> productSizeSpecifications)
        {
            _context.ProductSizeSpecifications.RemoveRange(productSizeSpecifications);
        }
    }
}

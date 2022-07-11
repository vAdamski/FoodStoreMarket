using FoodStoreMarket.Application.Ingredients.Commands.CreateIndegriment;
using FoodStoreMarket.Application.Ingredients.Commands.DeleteIngredient;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Ingredients.Queries.GetIngredientDetails;
using FoodStoreMarket.Application.Ingredients.Commands.EditIngredient;
using FoodStoreMarket.Application.Ingredients.Queries.GetAllIngredientsInRestaurant;

namespace FoodStoreMarket.Api.Controllers
{
    [Route("api/ingredients")]
    [EnableCors("MyAllowSecificOrigins")]
    public class IngredientsController : BaseController
    {
        /// <summary>
        /// Get igredient by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var ingredient = await Mediator.Send(new GetIngredientQuery {IngredientId = id});

            if (ingredient is null)
            {
                return NotFound();
            }
            
            return Ok(ingredient);
        }

        /// <summary>
        /// Get all ingredients in restaurant
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ingredientsInMenu/{menuId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllIngredientsForRestaurantAsync(int menuId)
        {
            var vm = await Mediator.Send(new GetAllIngredientsInRestaurantQuery { MenuId = menuId });

            if (vm is null)
            {
                return NotFound();
            }

            return Ok(vm);
        }

        /// <summary>
        /// Get all ingredients for product
        /// </summary>
        /// <returns></returns>
        [HttpGet("{ingredientId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllForProductAsync(int productId)
        {
            return Ok();
        }

        /// <summary>
        /// Add ingredient
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult<int>> PostAsync([FromBody] CreateIngredientCommand createIngredientCommand)
        {
            var vm = createIngredientCommand;

            var id = await Mediator.Send(vm);

            if (id != null)
            {
                // Implement Created
                return Ok(id);
            }

            return NotFound();
        }

        /// <summary>
        /// Update ingredient
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> PatchAsync([FromBody] EditIngredientCommand editIngredientCommand)
        {
            var response = await Mediator.Send(editIngredientCommand);

            if (response == false)
            {
                return NotFound();
            }

            return Ok();
        }

        /// <summary>
        /// Delete ingredient by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await Mediator.Send(new DeleteIngredientCommand { IngredientIdToDelete = id });

            return Ok();
        }
    }
}


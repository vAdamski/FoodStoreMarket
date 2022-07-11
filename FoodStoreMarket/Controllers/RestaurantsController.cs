using FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants;
using FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant;
using FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant;

namespace FoodStoreMarket.Api.Controllers
{
    [Route("api/restaurants")]
    [EnableCors("MyAllowSecificOrigins")]
    public class RestaurantsController : BaseController
    {
        /// <summary>
        /// Get restaurant by id
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
            var vm = await Mediator.Send(new GetRestaurantDetailQuery() { RestaurantId = id });

            return Ok(vm);
        }

        /// <summary>
        /// Get all restaurants in resturant
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllAsync()
        {
            var vm = await Mediator.Send(new GetRestaurantsQuery { });

            return Ok(vm);
        }

        /// <summary>
        /// Add restaurant
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult<int>> PostAsync([FromBody]CreateRestaurantCommand restaurantCommand)
        {
            var vm = restaurantCommand;

            var id = await Mediator.Send(vm);

            if (id != null)
            {
                // Implement Created
                return Ok(id);
            }
            return NotFound();
        }

        /// <summary>
        /// Update restaurant
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> PatchAsync()
        {
            return null;
        }

        /// <summary>
        /// Delete restaurant by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await Mediator.Send(new DeleteRestaurantCommand() { IdRestaurantToDelete = id });
            return Ok();
        }
    }
}

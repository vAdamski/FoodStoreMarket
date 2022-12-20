using FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants;
using FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail;
using FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant;
using FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodStoreMarket.Api.Controllers
{
    [Route("api/restaurants")]
    public class RestaurantsController : BaseController
    {
        /// <summary>
        /// Get restaurant by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetById(int id)
        {
            var vm = await Mediator.Send(new GetRestaurantDetailQuery() { RestaurantId = id });

            return Ok(vm);
        }

        /// <summary>
        /// Get all restaurants in resturant
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "admin")]
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
        [AllowAnonymous]
        public async Task<ActionResult<int>> PostAsync([FromBody]CreateRestaurantCommand restaurantCommand)
        {
            if (restaurantCommand == null)
            {
                return BadRequest();
            }
            
            var responseId = await Mediator.Send(restaurantCommand);

            return CreatedAtAction(nameof(GetById), new {id = responseId}, restaurantCommand);
        }

        /// <summary>
        /// Update restaurant
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [AllowAnonymous]
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
        [AllowAnonymous]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await Mediator.Send(new DeleteRestaurantCommand() { IdRestaurantToDelete = id });
            return Ok();
        }
    }
}

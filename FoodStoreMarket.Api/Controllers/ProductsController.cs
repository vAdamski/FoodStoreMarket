using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Products.Commands.CreateProduct;
using FoodStoreMarket.Application.Products.Commands.DeleteProductCommand;
using FoodStoreMarket.Application.Products.Queries.GetProduct;

namespace FoodStoreMarket.Api.Controllers
{
    /// <summary>
    /// End-point to manage products/dishes in restaurant
    /// </summary>
    [Route("api/products")]
    public class ProductsController : BaseController
    {
        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById(int id)
        {
            var vm = await Mediator.Send(new GetProductQuery { ProductId = id });

            if (vm == null)
            {
                return NotFound();
            }

            return Ok(vm);
        }

        /// <summary>
        /// Get all products in resturant
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
            return null;
        }

        /// <summary>
        /// Add product to restaurant
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult> PostAsync([FromBody]CreateProductCommand command)
        {
            if (command == null)
            {
                return BadRequest();
            }
            
            var response = await Mediator.Send(command);
            
            return Ok(response);
        }

        /// <summary>
        /// Update product in restaurant
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
        /// Delete product in restaurant by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var response = await Mediator.Send(new DeleteProductCommand() { ProductId = id });

            if (response == false)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}

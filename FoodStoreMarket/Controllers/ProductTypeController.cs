using System;
using System.Threading.Tasks;
using FoodStoreMarket.Application.ProductTypes.Commands.AddNewProductType;
using FoodStoreMarket.Application.ProductTypes.Commands.DeleteProductType;
using FoodStoreMarket.Application.ProductTypes.Commands.UpdateProductType;
using FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreMarket.Api.Controllers;

[Route("api/productTypes")]
[EnableCors("MyAllowSpecificOrigins")]
public class ProductTypeController : BaseController
{
    /// <summary>
    /// Get productTypes in restaurant
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetAllProductTypesInRestaurant(int id)
    {
        try
        {
            var vm = await Mediator.Send(new GetAllProductTypesInRestaurantQuery() { RestaurantId = id });

            return Ok(vm);
        }
        catch (Exception e)
        {
            return NotFound();
            Console.WriteLine(e);
            throw;
        }
    }
    
    /// <summary>
    /// Add product type
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<ActionResult<int>> PostAsync([FromBody]AddNewProdcutTypeCommand prodcutTypeCommand)
    {
        var vm = prodcutTypeCommand;

        var id = await Mediator.Send(vm);

        if (id != null)
        {
            // Implement Created
            return Ok(id);
        }
        return NotFound();
    }
    
    /// <summary>
    /// Update product type
    /// </summary>
    /// <returns></returns>
    [HttpPatch]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<int>> PatchAsync([FromBody]UpdateProductTypeCommand  productTypeCommand)
    {
        var id = await Mediator.Send(productTypeCommand);
        
        return Ok(id);
    }
    
    /// <summary>
    /// Delete product type by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        await Mediator.Send(new DeleteProductTypeCommand() { ProductTypeId = id });
        return Ok();
    }
}
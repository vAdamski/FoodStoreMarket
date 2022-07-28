﻿using System;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Sizes.Commands.AddNewSize;
using FoodStoreMarket.Application.Sizes.Commands.DeleteSize;
using FoodStoreMarket.Application.Sizes.Commands.EditSize;
using FoodStoreMarket.Application.Sizes.Queries.GetSizeDetail;
using FoodStoreMarket.Application.Sizes.Queries.GetSizesInRestaurant;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreMarket.Api.Controllers;

[Route("api/sizes")]
[EnableCors("MyAllowSpecificOrigins")]
public class SizeController : BaseController
{
    /// <summary>
    /// Get size in restaurant by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetSize(int id)
    {
        var vm = await Mediator.Send(new GetSizeDetailQuery() { SizeId = id });

        return Ok(vm);
    }
    /// <summary>
    /// Get sizes in restaurant
    /// </summary>
    /// <param name="restaurantId"></param>
    /// <returns></returns>
    [HttpGet("{restaurantId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetAllSizesInRestaurant(int restaurantId)
    {
        var vm = await Mediator.Send(new GetSizesInRestaurantQuery() { RestaurantId = restaurantId });

        return Ok(vm);
    }
    
    /// <summary>
    /// Add size
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<ActionResult<int>> PostAsync([FromBody]AddNewSizeCommand prodcutTypeCommand)
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
    /// Update size
    /// </summary>
    /// <returns></returns>
    [HttpPatch]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<int>> PatchAsync([FromBody]EditSizeCommand  productTypeCommand)
    {
        var id = await Mediator.Send(productTypeCommand);
        
        return Ok(id);
    }
    
    /// <summary>
    /// Delete size by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        await Mediator.Send(new DeleteSizeCommand() { SizeIdToDelete = id });
        return Ok();
    }
}
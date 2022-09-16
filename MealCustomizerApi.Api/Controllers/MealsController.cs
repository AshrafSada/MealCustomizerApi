using MealCustomizerApi.Api.MealRecords;
using MealCustomizerApi.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealCustomizerApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MealsController : ControllerBase
{
    [HttpGet()]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        return Ok(id);
    }

    [HttpPost()]
    public IActionResult Post(CreateMealRequest request)
    {
        // creating new meal
        var meal = new Meal(Guid.NewGuid(),
            name: request.Name,
            description: request.Description,
            startDateTime: request.StartDateTime,
            endDateTime: request.EndDateTime,
            lastModifiedDateTime: DateTime.Now,
            savories: request.Savories,
            sweets: request.Sweets);
        // map the new meal to the response
        var response = new CreateMealResponse(Guid.NewGuid(),
                Name: meal.Name,
                Description: meal.Description,
                StartDateTime: meal.StartDateTime,
                EndDateTime: meal.EndDateTime,
                Savories: meal.Savories,
                Sweets: meal.Sweets);

        //return OK(response);
        return CreatedAtAction("post", new { id = meal.Id }, response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult Put(Guid id, UpsertMealRequest request)
    {
        return Ok(new { id, request });
    }

    [HttpDelete("{id:guid}")]
    public IActionResult Put(Guid id)
    {
        return Ok(id);
    }
}
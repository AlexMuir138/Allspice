using System.Collections.Generic;
using Allspice.Models;
using Allspice.Services;
using Microsoft.AspNetCore.Mvc;

namespace Allspice.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class RecipesController : ControllerBase
  {
    private readonly RecipesService _recServ;
    private readonly IngredientsService _ingServ
    public RecipesController(RecipesService recServ, IngredientsService ingServ)
    {
      recServ = _ingServ;
      ingServ = _recServ;
    }
    [HttpGet]
    public ActionResult <List<Recipe>> GetAllRecipes()
    {
    try
    {
        var recipes = _recServ.GetAllRecipes();
        return Ok(recipes);
    }
    catch (System.Exception e)
    {
        return BadRequest(e.Message);
    }
    }

    [HttpGet("{id}")]
     public ActionResult <List<Recipe>> GetRecipeById(int id)
    {
    try
    {
        var recipe = _recServ.GetRecipeById(id);
        return Ok(recipe);
    }
    catch (System.Exception e)
    {
        return BadRequest(e.Message);
    }
    }

    [HttpPost]
    {
      public ActionResult<Recipe> CreateRecipe([FromBody] Recipe recipeData)
      {
        try
        {
            var recipe = _recServ.CreateRecipe(recipeData);
          return Created($"api/recipes/{recipe.Id}", recipe);
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
      }
      [HttpPut]
      public ActionResult<Recipe> UpdateRecipe(int id, [FromBody] Recipe recipe)
      {
        try
        {
            return Ok(_recServ.UpdateRecipe(id, recipe));
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
      }
      [HttpDelete("{id}")]
      public ActionResult<Recipe> DeleteRecipe(int id)
      {
        try
        {
            return Ok(_recServ.DeleteRecipe(id));
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
      }
    }
  }
}
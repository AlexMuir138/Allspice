using System;
using System.Collections.Generic;
using Allspice.Models;
using Allspice.Repositories;

namespace Allspice.Services
{
  public class RecipesService
  {
    private readonly RecipesRepository _recRep;
    
    public RecipesService(RecipesRepository recRep)
    {
      _recRep = recRep;
    }
    public List<Recipe> GetAllRecipes()
    {
      var recipes = _recRep.GetAllRecipes();
      return recipes;
    }
    public List<Recipe> GetOne(int id)
    {
      return _recRep.GetOne(id);
    }
    public List<Recipe> CreateRecipe(Recipe recipeData)
    {
      var recipe = _recRep.CreateRecipe(recipeData);
      return recipe;
    }

    public List<Recipe> UpdateRecipe(int id, Recipe recipe)
    {
      recipe.Id = id;
      Recipe original = GetOne(id);
       recipe.Title = recipe.Title != null ? recipe.Title : original.Title; 
      recipe.Body = recipe.Body != null ? recipe.Body : original.Body; 
      recipe.ImgUrl = recipe.ImgUrl != null ? recipe.ImgUrl : original.ImgUrl; 

      int updated = _recRep.UpdateRecipe(recipe);
      if(updated > 0)
      {
        return recipe;
      }else
      {
        throw new Exception(" Not updated! ");
      }
    }
     public Recipe GetRecipeById(int id)
    {
      return _recRep.GetOne(id);
    }
    internal string DeleteRecipe(int id)
    {
      int updated = _recRep.DeleteRecipe(id);
      if(updated > 0)
      {
        return "Deleted";
      }
      else
      {
        throw new Exception("Not Deleted Bruh");
      }
    }
  }
}
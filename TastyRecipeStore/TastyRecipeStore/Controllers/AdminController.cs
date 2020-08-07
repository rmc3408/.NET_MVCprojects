using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TastyRecipeStore.Models;

namespace TastyRecipeStore.Controllers
{
    public class AdminController : Controller
    {
        private IRecipeRepository manageRecipes;

        public AdminController(IRecipeRepository toManageRecipe)
        {
            manageRecipes = toManageRecipe;
        }
         

        public ViewResult Index()
        {
            return View(manageRecipes.FoodRepository);
        }
        
        [HttpGet]
        public ViewResult Edit(int selected)
        {
            return View(manageRecipes.FoodRepository
                .FirstOrDefault(p =>p.RecipeID == selected));
        }

        [HttpPost]
        public IActionResult Edit(Recipe rec)
        {
            if (ModelState.IsValid)
            {
                manageRecipes.updateRecipe(rec);
                TempData["message"] = $"{rec.Name} has been saved!";
                return RedirectToAction("Index");
            }
            else
            {                
                return View(rec);
            }

        }
        public ViewResult Create() => View("Edit", new Recipe());


        [HttpPost]
        public IActionResult Delete(int toBeDelete)
        {
            Recipe removedNameOfRecipe = manageRecipes.removeRecipe(toBeDelete);

            if(removedNameOfRecipe != null)
            {
                TempData["byeMsg"] = $"{removedNameOfRecipe.Name} has removed!";
            }

            return RedirectToAction("Index");
        }
    }
}

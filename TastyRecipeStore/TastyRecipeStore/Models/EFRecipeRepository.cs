using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TastyRecipeStore.Models;

namespace TastyRecipeStore.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private AppDatabase context;

       
        public EFRecipeRepository(AppDatabase ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> FoodRepository { get { return context.PackofRecipes; } }
           
        public void updateRecipe(Recipe theRecipe)
        {
            if(theRecipe.RecipeID == 0)
            {
                context.PackofRecipes.Add(theRecipe);
            }
            else
            {
                Recipe newEntry = context.PackofRecipes
                    .FirstOrDefault(p => p.RecipeID == theRecipe.RecipeID);

                if(newEntry != null)
                {
                    newEntry.Name = theRecipe.Name;
                    newEntry.Description = theRecipe.Description;
                    newEntry.Chef = theRecipe.Chef;
                    newEntry.PreparationTime = theRecipe.PreparationTime;
                    newEntry.Ingredient = theRecipe.Ingredient;
                }
            }
            context.SaveChanges();
            
        }
        public Recipe removeRecipe(int id)
        {
            Recipe newEntry = context.PackofRecipes
                     .FirstOrDefault(p => p.RecipeID == id);

            if (newEntry != null)
            {
                context.PackofRecipes.Remove(newEntry);
                context.SaveChanges();
            }
            return newEntry;
        }


    }
}

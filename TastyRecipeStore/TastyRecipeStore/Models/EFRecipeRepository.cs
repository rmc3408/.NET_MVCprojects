using System;
using System.Collections.Generic;
using System.Linq;
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
           

    }
}

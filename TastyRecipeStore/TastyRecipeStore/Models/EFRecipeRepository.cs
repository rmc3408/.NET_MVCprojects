using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyRecipeStore.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private AppDatabase context;

        public IQueryable<Recipe> FoodRepository => context.PackofRecipes;

        public EFRecipeRepository(AppDatabase ctx)
        {
            context = ctx;
        }


    }
}

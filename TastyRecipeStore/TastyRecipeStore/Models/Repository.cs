using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyRecipeStore.Models
{
    public static class Repository
    {
        private static List<Recipe> packOfRecipe = new List<Recipe>();

        public static IQueryable<Recipe> PackOfRecipe => packOfRecipe.AsQueryable<Recipe>();

        public static void AddToList(Recipe r)
        {
            packOfRecipe.Add(r);
        }
        
    }
} 

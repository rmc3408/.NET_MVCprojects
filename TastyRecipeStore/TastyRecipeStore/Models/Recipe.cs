using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyRecipeStore.Models
{
    public class Recipe
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Chef { get; set; }
        public string PreparationTime { get; set; }
        public string Ingredient { get; set; }
        

    }
}

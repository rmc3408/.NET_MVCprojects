using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyRecipeStore.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> FoodRepository { get; }
    }
}

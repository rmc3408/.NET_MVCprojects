using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyRecipeStore.Models
{
    public static class SeedData
    {
        public static void AddSeeds(IApplicationBuilder app)
        {
            AppDatabase tempDatabase = app.ApplicationServices.GetRequiredService<AppDatabase>();

            tempDatabase.Database.Migrate();

            if(!tempDatabase.PackofRecipes.Any())
            {
                tempDatabase.PackofRecipes.AddRange(
                    new Recipe()
                    {
                        Chef = "StevenDion",
                        Name = "Chicken Cesar Salad",
                        Description = "A Caesar salad is a green salad of romaine lettuce and croutons dressed with lemon juice," +
                        " olive oil, egg, Worcestershire sauce, anchovies, garlic, Dijon mustard, Parmesan cheese, and black pepper." +
                        " In its original form, this salad was prepared and served tableside. ",
                        PreparationTime = "15",
                        Ingredient = " 1 pound (454 grams) cooked chicken breast, " +
                        "1 head of Lettuce," + "2 tablespoon freshly squeezed lemon juice"
                    });
            }

            tempDatabase.SaveChanges();
        }
    }
}

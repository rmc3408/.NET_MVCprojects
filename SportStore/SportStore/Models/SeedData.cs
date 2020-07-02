using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SportStore.Models
{
    public static class SeedData
    {
        public static void EnsurePop(IApplicationBuilder app)
        {
            DataB context = app.ApplicationServices.GetRequiredService<DataB>();
            
            context.Database.Migrate();

            if (!context.ProductsInDatabase.Any())
            {
                context.ProductsInDatabase.AddRange(

                    new Product
                    {
                        Name = "SoccerBall",
                        Description = "hard ball",
                        Price = 15.50,
                        Category = "Outside"
                    },
                    new Product
                    {
                        Name = "Tennis",
                        Description = "tiny and yellow ball",
                        Price = 2.00,
                        Category = "Outside"
                    },
                    new Product
                    {
                        Name = "Swimming Glasses",
                        Description = "Waterproof",
                        Price = 7.00,
                        Category = "Inside"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
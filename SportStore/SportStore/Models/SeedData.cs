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
                    },
                    new Product
                    {
                        Name = "BasketBal",
                        Description = "big ball",
                        Price = 10.50,
                        Category = "Outside"
                    },
                    new Product
                    {
                        Name = "Tennis table",
                        Description = "tiny white ball",
                        Price = 1.00,
                        Category = "Inside"
                    },
                    new Product
                    {
                        Name = "Waterpolo Ball",
                        Description = "Waterproof ball",
                        Price = 22.50,
                        Category = "Inside"
                    }
                    ,
                    new Product
                    {
                        Name = "American FootBall",
                        Description = "Funny shape ball",
                        Price = 18.00,
                        Category = "Outside"
                    },
                    new Product
                    {
                        Name = "Video Game",
                        Description = "Game",
                        Price = 207.00,
                        Category = "Gaming"
                    },
                    new Product
                    {
                        Name = "Chess Game",
                        Description = "Board",
                        Price = 9.90,
                        Category = "Gaming"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
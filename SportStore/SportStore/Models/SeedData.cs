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
                        Name = "Football",
                        Description = "Good ball",
                        Price = 25.50,
                        Category = "camp"
                    },
                    new Product
                    {
                        Name = "Soccer",
                        Description = "small ball",
                        Price = 15.50,
                        Category = "outside camp"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
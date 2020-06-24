using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    //this is a hardCoded List, replace database.

    public class FakeProductsRep : IProductRepository
    {
        public IQueryable<Product> PackProducts => new List<Product>
        {
            new Product { Name = "Football", Price = 25.50 },
            new Product { Name = "Soccer", Price = 179.02 },
            new Product { Name = "Running shoes", Price = 95.99 }

        }.AsQueryable<Product>();


    }
}

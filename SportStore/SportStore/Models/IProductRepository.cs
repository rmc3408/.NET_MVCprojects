using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    // not concrete class... Do not create object//
    public interface IProductRepository
    {
        /*
         * It has as good performance to Database. filter data.
         * dont download whole object to the memory. 
         * select filtered data */

        IQueryable<Product> PackProducts { get; }

    }
}

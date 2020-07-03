using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStore.Models;

namespace SportStore.Models.ViewModels
{
    public class ProductsViewModel
    {
        public IQueryable<Product> PackProducts { get; set; }
        public PagingInfo PageInfo { get; set; }



    }
}

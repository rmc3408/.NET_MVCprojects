using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository reps;
        public const int pageSize = 4;


        public ProductController(IProductRepository r)
        {
            reps = r;
        }

        public ViewResult List(int pPage = 1) => 
            
            View(reps.PackProducts
                .OrderBy(p => p.ProductID)
                .Skip((pPage - 1)* pageSize)
                .Take(pageSize));
        
    }
}

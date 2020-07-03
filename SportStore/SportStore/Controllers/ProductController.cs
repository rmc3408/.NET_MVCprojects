using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository reps;
        public int pageSize = 3;


        public ProductController(IProductRepository r)
        {
            reps = r;
        }

        public ViewResult List(int productPage = 1) =>

            View(new ProductsViewModel
            {
                PackProducts = reps.PackProducts.OrderBy(p => p.Category)
                        .Skip((productPage - 1) * pageSize).Take(pageSize),

                PageInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = pageSize,
                    TotalItems = reps.PackProducts.Count()

                }
            });
        
            
            
        
    }
}

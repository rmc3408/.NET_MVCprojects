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


        public ProductController(IProductRepository r)
        {
            reps = r;
        }

        public ViewResult List()
        {
            return View(reps.PackProducts);
        }
    }
}

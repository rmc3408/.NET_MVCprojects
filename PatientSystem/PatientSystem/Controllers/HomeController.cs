using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientSystem.Models;

namespace PatientSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View("Register");
        }
        
        [HttpGet]
        public IActionResult List()
        {

            return View("List");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRepair301098080.Models;

namespace CarRepair301098080.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ViewResult Index()
        {

            int regtime = DateTime.Now.Hour;
            if (regtime < 12)
            {
                ViewBag.Greeting = "Good Morning";
            }
            else if (regtime > 17)
            {
                ViewBag.Greeting = "Good Night";
            }
            else
            {
                ViewBag.Greeting = "Good Afternoon";
            }

            return View("Register");
        }

        [HttpPost]
        public ViewResult Thanks(Car theCar)
        {
            DateTime clicked = DateTime.Now;
            theCar.CurrentDateAndTime = clicked;

            Repo.AddCar(theCar);
            return View(theCar);
        }

        public ViewResult List()
        {
            return View(Repo.Bundle.OrderBy(s => s.Name));
        }

        public ViewResult Details(string id)
        {
            return View(Repo.Bundle.Where(s => s.Name == id));
        }

        public ViewResult Register()
        {
            return View();
        }
    }
}

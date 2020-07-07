using Microsoft.AspNetCore.Mvc;
using PatientSystem.Models;
using System;
using System.Linq;

namespace PatientSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            int regtime = DateTime.Now.Hour;
            ViewBag.Greeting = regtime >= 12 ? "Good Afternoon" : "Good Morning";
            return View("Register");
        }

        [HttpPost]
        public ViewResult Thanks(Patient thesick)
        {
            DateTime clicked = DateTime.Now;
            thesick.CurrentDateAndTime = clicked;

            Repo.AddPatToRep(thesick);
            return View(thesick);
        }

        public ViewResult List()
        {
            return View(Repo.Sicks.OrderBy(s => s.Name));
        }


    }
}
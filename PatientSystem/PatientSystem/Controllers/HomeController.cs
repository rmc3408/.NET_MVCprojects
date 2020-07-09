using Microsoft.AspNetCore.Mvc;
using PatientSystem.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PatientSystem.Controllers
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

        public ViewResult Details(string id)
        {
           return View(Repo.Sicks.Where(s => s.Name == id));
        }


    }
}
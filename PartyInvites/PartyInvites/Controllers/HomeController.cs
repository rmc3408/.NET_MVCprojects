using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //default action method

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            

            return View();
        }
        
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                //it will chose thanks page in View(MVC) and send object info.
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
            
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Resp.Where(r => r.WillAttend == true));
        }

    }
}

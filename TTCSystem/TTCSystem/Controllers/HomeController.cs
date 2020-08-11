using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTCSystem.Models;

namespace TTCSystem.Controllers
{
	public class HomeController : Controller
    {
        private IBusRepository repository;

        public HomeController(IBusRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View("List", repository.Buses);
        }

        [HttpPost]
        public IActionResult Delete(int busNumber)
        {
            Bus deletedBus = repository.DeleteBus(busNumber);

            return RedirectToAction("Index");
        }

        public ViewResult Edit(int id) =>
            View(repository.Buses
                .FirstOrDefault(p => p.BusNumber == id));

        [HttpPost]
        public IActionResult Edit(Bus bus)
        {
            
            if (ModelState.IsValid)
            {
                repository.SaveBus(bus);
                return RedirectToAction("Index");
            }
            else
            {
                return View(bus);
            }
        }

        public ViewResult Create() => View("Edit", new Bus());
    }
}

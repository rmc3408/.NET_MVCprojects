using bhrugen_patel.Data;
using bhrugen_patel.Models;
using Microsoft.AspNetCore.Mvc;

namespace bhrugen_patel.Controllers
{
    public class CategoryController : Controller
    {
        private AppDbContext _context;
        public CategoryController(AppDbContext ctx) { 
            _context = ctx;
        }
        public IActionResult Index()
        {
            List<Category> list = _context.Categories.ToList();
            return View(list);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category newObj)
        {
            if (newObj.Name == newObj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Cannot be same as display order");
                ModelState.AddModelError("", "Change name");
            }
            if (ModelState.IsValid)
            {
                _context.Categories.Add(newObj);
                _context.SaveChanges();
                TempData["success"] = "Category succesful created";
                return RedirectToAction("Index", "Category");
            }
            return View(newObj);
        }

        public IActionResult Edit(int? id)
        {
            Category? foundItem = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (id == null || id == 0 || foundItem == null)
            {
                return NotFound();
            }
            return View(foundItem);
        }

        [HttpPost]
        public IActionResult Edit(Category newObj)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(newObj);
                _context.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View(newObj);
        }

        [HttpGet, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            Category? found = _context.Categories.Find(id);
            if (found == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(found);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

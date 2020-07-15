using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TastyRecipeStore.Models;

namespace TastyRecipeStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Form()
        {
            //Open Form action.
            return View();
        }

        [HttpPost]
        public ViewResult Form(Recipe recipeFromForm)
        {
            //Add Object from FORM to the List<recipe>
            Repository.AddToList(recipeFromForm);

            return View("Index");
        }

        public ViewResult List()
        {
            return View(Repository.PackOfRecipe);
        }

        public ViewResult ViewRecipe(string id)
        {
            return View(Repository.PackOfRecipe.FirstOrDefault(p => p.Name == id));
        }

        public ViewResult Review()
        {
            return View();
        }
    }
}
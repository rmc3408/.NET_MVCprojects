using Microsoft.AspNetCore.Mvc;
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

        public ViewResult ViewRecipe()
        {
            return View(Repository.PackOfRecipe);
        }

        public ViewResult Review()
        {
            return View();
        }
    }
}
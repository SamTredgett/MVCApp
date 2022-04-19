using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Hello()
        {
            DogViewModel otherdoggo = new() { Name = "Jeremiah", Age = 3 };
            return View(otherdoggo);
        }
        
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);  
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}

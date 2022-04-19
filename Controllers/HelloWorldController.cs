using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new() { Name = "Henry", Age = 1 };
            return View(doggo);
        }

        public IActionResult Hello()
        {
            DogViewModel otherdoggo = new() { Name = "Jeremiah", Age = 3 };
            return View(otherdoggo);
        }
        
        public IActionResult Create()
        {
            return View();  
        }
    }
}

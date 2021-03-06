using dotNetCoreMVC4Turkcell.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotNetCoreMVC4Turkcell.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 24;
            ViewBag.Name = "Taylan";
            return View();
        }

        [HttpGet] 
        public IActionResult Register() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks");
            }
            return View();
        }
    }
}

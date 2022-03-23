using Microsoft.AspNetCore.Mvc;

namespace dotNetCoreMVC4Turkcell.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Age = 24;
            ViewBag.Name = "Taylan";
            return View();
        }

        public IActionResult Register() 
        { 
            return View(); 
        }
    }
}

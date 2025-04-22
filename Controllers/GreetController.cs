using Microsoft.AspNetCore.Mvc;

namespace DevOpsMidterm.Controllers
{
    public class GreetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Greet(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}

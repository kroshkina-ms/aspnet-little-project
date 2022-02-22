using Microsoft.AspNetCore.Mvc;

namespace OlgasLittleMvc3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AwesomePost()
        {
            ViewData["Message"] = "Awesome page for a POST route.";

            return View();
        }
    }
}

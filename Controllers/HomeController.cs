using Microsoft.AspNetCore.Mvc;

namespace Companies.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
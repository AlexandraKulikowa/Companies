using Companies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Companies.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var companies = repository.GetCompanies();
            return View(companies);
        }
    }
}
using Companies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Companies.Controllers
{
    public class DetailsController : Controller
    {
        private IRepository repository;
        public DetailsController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index(int id)
        {
            var company = repository.GetCompanyById(id);
            return View(company);
        }

        public IActionResult EditEmployee(int employeeId, int id)
        {
            repository.AddEmployeeToEdit(id, employeeId);
            var company = repository.GetCompanyById(id);
            return View("Index", company);
        }
    }
}
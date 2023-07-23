using Companies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Companies.Views.Shared.Components.Employee
{
    public class EmployeeViewComponent : ViewComponent
    {
        IRepository repository;

        public EmployeeViewComponent(IRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            var company = repository.GetCompanyById(id);
            if(company.EmployeeForChange != null)
            {
                return View("Employee", company.EmployeeForChange);
            }

            var firstEmployee = company.Employees.FirstOrDefault();
            return View("Employee", firstEmployee);
        }
    }
}
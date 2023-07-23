using Companies.Database;
using Companies.Interfaces;
using Companies.Models;
using Microsoft.EntityFrameworkCore;

namespace Companies.Repositories
{
    public class Repository : IRepository
    {

        private DatabaseContext dbContext;
        public Repository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Company> GetCompanies() 
        {
            var companies = dbContext.Companies
               .Include(x => x.City)
               .Include(x => x.State)
               .ToList();
            return companies;
        }

        public Company GetCompanyById(int id)
        {
            return dbContext.Companies
               .Include(x => x.City)
               .Include(x => x.State)
               .Include(x => x.Orders)
               .ThenInclude(x => x.City)
               .Include(x => x.Notes)
               .ThenInclude(x => x.Employee)
               .Include(x => x.Employees)
               .FirstOrDefault(company => company.Id == id);
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = dbContext.Employees.FirstOrDefault(x => x.Id == id);
            return employee;
        }

        public void AddEmployeeToEdit(int companyId, int employeeId)
        {
            var company = GetCompanyById(companyId);
            var employee = GetEmployeeById(employeeId);
            company.EmployeeForChange = employee;
            dbContext.SaveChanges();            
        }
    }
}
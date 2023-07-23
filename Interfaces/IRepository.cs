using Companies.Models;

namespace Companies.Interfaces
{
    public interface IRepository
    {
        List<Company> GetCompanies();
        Company GetCompanyById(int id);
        Employee GetEmployeeById(int id);
        void AddEmployeeToEdit(int companyId, int employeeId);
    }
}
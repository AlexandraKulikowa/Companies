using System.ComponentModel.DataAnnotations.Schema;

namespace Companies.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public List<Order> Orders { get; set; }
        public List<Note> Notes { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public List<Employee> Employees { get; set; }

        [NotMapped]
        public Employee? EmployeeForChange { get; set; }
    }
}
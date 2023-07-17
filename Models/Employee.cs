
namespace Companies.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public Notes Notes { get; set; }
    }
}
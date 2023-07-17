namespace Companies.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Order> History { get; set; }
        public List<Note> Notes { get; set; }
    }
}
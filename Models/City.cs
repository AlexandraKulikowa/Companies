namespace Companies.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List <Company> Companies { get; set; }
        public List<Order> Orders { get; set; }
    }
}
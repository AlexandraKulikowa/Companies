namespace Companies.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List <Company>? Companys { get; set; }
        public List<Order>? Historys { get; set; }
    }
}
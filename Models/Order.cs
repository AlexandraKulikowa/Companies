namespace Companies.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateOnly OrderDate { get; set; }
        public City City { get; set; }
        public Company Company { get; set; }
        public int CityId { get; set; }
        public int CompanyId { get; set; }
    }
}
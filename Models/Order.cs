namespace Companies.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public City StoreCity { get; set; }
        public Company Company { get; set; }

    }
}
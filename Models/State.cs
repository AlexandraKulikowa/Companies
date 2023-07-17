namespace Companies.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Company> Companys { get; set; }
    }
}
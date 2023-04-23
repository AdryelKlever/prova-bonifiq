namespace ProvaPub.Models
{
    public class ModelList
    {
        public List<Product> Products { get; set; }
        public List<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}

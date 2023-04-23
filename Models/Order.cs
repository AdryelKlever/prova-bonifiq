namespace ProvaPub.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Value { get; set; }
		public int CustomerId { get; set; }
		public DateTime OrderDate { get => DateTime.Now; }
		public Customer Customer { get; set; }
	}
}

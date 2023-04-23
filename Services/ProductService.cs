using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class ProductService
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

		public ModelList ListProducts(int page)
		{
			return new ModelList() 
			{  
				HasNext = false, 
				TotalCount = 10, 
				Products = _ctx.Products.Skip((page - 1) * 10).Take(10).ToList()
			};
		}

	}
}

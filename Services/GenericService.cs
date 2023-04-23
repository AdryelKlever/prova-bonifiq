using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class GenericService
    {
        TestDbContext _ctx;

        public GenericService(TestDbContext ctx) 
        {
            _ctx = ctx;
        }

        public ModelList GetAll(int page)
        {
            return new ModelList()
            {
                HasNext = false,
                TotalCount = 10,
                Customers = _ctx.Customers.Skip((page - 1) * 10).Take(10).ToList()
            };
        }
    }
}

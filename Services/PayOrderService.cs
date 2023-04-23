using ProvaPub.Models;

namespace ProvaPub.Services
{
    public class PayOrderService
    {
        public async Task<Order> Pix(string paymentMethod, decimal paymentValue)
        {
            return await Task.FromResult(new Order()
            {
                Name = paymentMethod,
                Value = paymentValue
            });
        }

        public async Task<Order> Creditcard(string paymentMethod, decimal paymentValue)
        {
            return await Task.FromResult(new Order()
            {
                Name = paymentMethod,
                Value = paymentValue
            });
        }

        public async Task<Order> PayPal(string paymentMethod, decimal paymentValue)
        {
            return await Task.FromResult(new Order()
            {
                Name = paymentMethod,
                Value = paymentValue
            });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ProvaPub.Models;
using ProvaPub.Services;

namespace ProvaPub.Controllers
{

	/// <summary>
	/// Esse teste simula um pagamento de uma compra.
	/// O método PayOrder aceita diversas formas de pagamento. Dentro desse método é feita uma estrutura de diversos "if" para cada um deles.
	/// Sabemos, no entanto, que esse formato não é adequado, em especial para futuras inclusões de formas de pagamento.
	/// Como você reestruturaria o método PayOrder para que ele ficasse mais aderente com as boas práticas de arquitetura de sistemas?
	/// </summary>

	[ApiController]
	[Route("[controller]")]
	public class Parte3Controller :  ControllerBase
	{
        private readonly PayOrderService _payOrderService;

		public Parte3Controller(PayOrderService payOrderService)
		{
			_payOrderService = payOrderService;
		}

        [HttpGet("orders")]
		public async Task<ActionResult> PlaceOrder(string paymentMethod, decimal paymentValue)
		{
			if (paymentMethod.ToUpper() == "PIX")
			{
				var result = await _payOrderService.Pix(paymentMethod, paymentValue);

				return Ok(result);
			}
			else if (paymentMethod.ToUpper() == "CREDITCARD")
			{
                var result = await _payOrderService.Creditcard(paymentMethod, paymentValue);

                return Ok(result);
            }
			else if (paymentMethod.ToUpper() == "PAYPAL")
			{
                var result = await _payOrderService.PayPal(paymentMethod, paymentValue);

                return Ok(result);
            }

			return NotFound();
		}
	}
}

using WebAPI.Interfaces.Factory;

namespace WebAPI.Services.Factory
{
    public class PaypalPaymentMethod : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Paying {amount} using Paypal Payment Method";
        }
    }
}

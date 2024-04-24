using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class PaypalPaymentMethod : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Paying {amount} using Paypal Payment Method";
        }
    }
}

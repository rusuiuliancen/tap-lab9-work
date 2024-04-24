using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class CardPaymentMethod : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Paying {amount} using Card Payment Method";
        }
    }
}

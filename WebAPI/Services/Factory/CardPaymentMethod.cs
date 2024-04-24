using WebAPI.Interfaces.Factory;

namespace WebAPI.Services.Factory
{
    public class CardPaymentMethod : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Paying {amount} using Card Payment Method";
        }
    }
}

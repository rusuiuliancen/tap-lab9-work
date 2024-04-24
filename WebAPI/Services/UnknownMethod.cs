using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class UnknownMethod : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return "Unknown payment method";
        }
    }
}

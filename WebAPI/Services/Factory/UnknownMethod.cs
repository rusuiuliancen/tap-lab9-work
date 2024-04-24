using WebAPI.Interfaces.Factory;

namespace WebAPI.Services.Factory
{
    public class UnknownMethod : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return "Unknown payment method";
        }
    }
}

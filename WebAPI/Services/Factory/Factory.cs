using WebAPI.Interfaces.Factory;

namespace WebAPI.Services.Factory
{
    public class Factory : IFactory
    {
        public IPaymentMethod GetPaymentMethod(string paymentMethod)
        {
            if (paymentMethod == "paypal")
            {
                return new PaypalPaymentMethod();
            }
            else if (paymentMethod == "creditcard")
            {
                return new CardPaymentMethod();
            }
            else
            {
                return new UnknownMethod();
            }
        }
    }
}

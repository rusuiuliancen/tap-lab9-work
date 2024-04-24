namespace WebAPI.Interfaces.Factory
{
    public interface IFactory
    {
        IPaymentMethod GetPaymentMethod(string paymentMethod);
    }
}

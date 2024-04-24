namespace WebAPI.Interfaces
{
    public interface IFactory
    {
        IPaymentMethod GetPaymentMethod(string paymentMethod);
    }
}

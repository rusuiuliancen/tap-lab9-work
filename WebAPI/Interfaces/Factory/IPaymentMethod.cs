namespace WebAPI.Interfaces.Factory
{
    public interface IPaymentMethod
    {
        string Pay(decimal amount);
    }
}

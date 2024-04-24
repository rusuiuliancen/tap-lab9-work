namespace WebAPI.Interfaces
{
    public interface IPaymentMethod
    {
        string Pay(decimal amount);
    }
}

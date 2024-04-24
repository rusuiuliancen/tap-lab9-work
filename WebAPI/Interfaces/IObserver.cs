namespace WebAPI.Interfaces
{
    public interface IObserver
    {
        string Update(ISubject subject);
    }
}

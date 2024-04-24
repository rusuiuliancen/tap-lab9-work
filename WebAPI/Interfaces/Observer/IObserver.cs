namespace WebAPI.Interfaces.Observer
{
    public interface IObserver
    {
        string Update(ISubject subject);
    }
}

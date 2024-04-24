namespace WebAPI.Interfaces
{
    public interface ISubject
    {
        void Attach(IObserver obs);
        void Dettach(IObserver obs);

        void Notify();
    }
}

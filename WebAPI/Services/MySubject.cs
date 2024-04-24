using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class MySubject : ISubject
    {
        private IList<IObserver> _observers = new List<IObserver>();

        public int State { get; set; }

        public void Attach(IObserver obs)
        {
            _observers.Add(obs);
        }

        public void Dettach(IObserver obs)
        {
            _observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            } 
        }
    }
}

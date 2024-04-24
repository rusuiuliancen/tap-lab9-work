using WebAPI.Interfaces.Observer;

namespace WebAPI.Services.Observer
{
    public class MyObserver : IObserver
    {
        public string Update(ISubject subject)
        {
            if (subject is MySubject s && s.State == 3)
            {
                return "MyObserver hit the jackpot!";
            }

            return null;
        }
    }
}

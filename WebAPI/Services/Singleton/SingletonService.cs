using WebAPI.Interfaces.Singleton;

namespace WebAPI.Services.Singleton
{
    public class SingletonService : ISingletonService
    {
        private readonly DateTime _instanceCreationDate;
        public SingletonService()
        {
            _instanceCreationDate = DateTime.Now;
        }

        public DateTime GetIntstanceCreationDate()
        {
            return _instanceCreationDate;
        }
    }
}

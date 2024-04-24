using WebAPI.Interfaces.Strategy;

namespace WebAPI.Services.Strategy
{
    public class GoogleAuthStrategy : IStrategy
    {
        public string DoOperation()
        {
            return "Google Auth Strategy processing...";
        }
    }
}

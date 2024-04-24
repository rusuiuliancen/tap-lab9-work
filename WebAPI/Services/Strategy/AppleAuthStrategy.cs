using WebAPI.Interfaces.Strategy;

namespace WebAPI.Services.Strategy
{
    public class AppleAuthStrategy : IStrategy
    {
        public string DoOperation()
        {
            return "Apple Auth Strategy processing...";
        }
    }
}

using WebAPI.Interfaces.Strategy;

namespace WebAPI.Services.Strategy
{
    public class CredentialsAuthStrategy : IStrategy
    {
        public string DoOperation()
        {
            return "Credentials Auth Strategy processing...";
        }
    }
}

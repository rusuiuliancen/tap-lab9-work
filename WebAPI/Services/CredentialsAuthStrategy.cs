using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class CredentialsAuthStrategy : IStrategy
    {
        public string DoOperation()
        {
            return "Credentials Auth Strategy processing...";
        }
    }
}

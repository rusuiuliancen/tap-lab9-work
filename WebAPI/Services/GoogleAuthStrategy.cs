using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class GoogleAuthStrategy: IStrategy
    {
        public string DoOperation()
        {
            return "Google Auth Strategy processing...";
        }
    }
}

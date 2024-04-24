using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class AppleAuthStrategy: IStrategy
    {
        public string DoOperation()
        {
            return "Apple Auth Strategy processing...";
        }
    }
}

using WebAPI.Interfaces.Strategy;

namespace WebAPI.Services.Strategy
{
    public class AuthContext
    {
        private IStrategy _strategy;

        public AuthContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string ExecuteStrategy()
        {
            return "Context started: " + _strategy.DoOperation();
        }
    }
}

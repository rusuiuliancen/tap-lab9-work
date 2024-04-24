using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces.Adapter;
using WebAPI.Interfaces.Factory;
using WebAPI.Interfaces.Singleton;
using WebAPI.Interfaces.Strategy;
using WebAPI.Services;
using WebAPI.Services.Observer;
using WebAPI.Services.Strategy;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignPatternController : ControllerBase
    {
        private readonly ISingletonService _singletonService;
        private readonly IFactory _factory;
        private readonly ITemperature _temperature;
        public DesignPatternController(ISingletonService singletonService, IFactory factory, ITemperature temperature)
        {
            _singletonService = singletonService;
            _factory = factory;
            _temperature = temperature;
        }

        [HttpGet("singleton")]
        public IActionResult Get()
        {
            return Ok(_singletonService.GetIntstanceCreationDate());
        }

        [HttpGet("factory")]
        public IActionResult Get2(string paymentMethod)
        {
            return Ok(_factory.GetPaymentMethod(paymentMethod).Pay(10));
        }

        [HttpGet("observer")]
        public IActionResult Get3()
        {
            var observer = new MyObserver();
            var subject = new MySubject();

            subject.Attach(observer);
            subject.State = 3;
            subject.Notify();

            return Ok();
        }

        [HttpGet("adapter")]
        public IActionResult Get4()
        {
            
            return Ok(_temperature.GetTemperature());
        }

        [HttpGet("strategy")]
        public string Get5(string authType){
            IStrategy strategy = null;

            if (authType == "apple")
            {
                strategy = new AppleAuthStrategy();
            }else if (authType == "google")
            {
                strategy = new GoogleAuthStrategy();
            }
            else
            {
                strategy = new CredentialsAuthStrategy();
            }

            var authContext = new AuthContext(strategy);

            return authContext.ExecuteStrategy();
        }
    }
}

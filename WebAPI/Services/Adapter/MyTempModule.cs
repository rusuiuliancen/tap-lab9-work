using WebAPI.Interfaces.Adapter;

namespace WebAPI.Services.Adapter
{
    public class MyTempModule : ITemperature
    {
        private readonly LegacyTempService _temperatureService;
        public MyTempModule()
        {
            _temperatureService = new LegacyTempService();
        }

        public double GetTemperature()
        {
            return _temperatureService.GetTemperature() - 33;
        }
    }
}

using Meadow.Foundation.Sensors.Atmospheric;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Atmospheric
{
    public class TemperatureHumiditySensor_HighAccuracyMini : Th02
    {
        public TemperatureHumiditySensor_HighAccuracyMini(II2cBus i2cBus) : base(i2cBus, 64)
        {
        }
    }
}
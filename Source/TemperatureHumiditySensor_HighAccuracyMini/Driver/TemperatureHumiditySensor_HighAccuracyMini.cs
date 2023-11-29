using Meadow.Foundation.Sensors.Atmospheric;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Atmospheric
{
    /// <summary>
    /// Represents a Temperature HumiditySensor HighAccuracy Mini
    /// </summary>
    public class TemperatureHumiditySensor_HighAccuracyMini : Th02
    {
        /// <summary>
        /// Creates a TemperatureHumiditySensor_HighAccuracyMini driver
        /// </summary>
        /// <param name="i2cBus"></param>
        public TemperatureHumiditySensor_HighAccuracyMini(II2cBus i2cBus)
            : base(i2cBus, 64)
        { }
    }
}
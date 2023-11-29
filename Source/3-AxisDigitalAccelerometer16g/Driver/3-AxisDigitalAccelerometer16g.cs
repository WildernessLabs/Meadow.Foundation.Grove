using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    /// <summary>
    /// Represents a 3 Axis Digital Accelerometer1_16g Sensor
    /// </summary>
    public class ThreeAxisDigitalAccelerometer16g : Adxl345
    {
        /// <summary>
        /// Creates a new ThreeAxisDigitalAccelerometer16g driver
        /// </summary>
        /// <param name="i2CBus"></param>
        public ThreeAxisDigitalAccelerometer16g(II2cBus i2CBus)
            : base(i2CBus)
        { }
    }
}
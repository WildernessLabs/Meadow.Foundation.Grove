using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    /// <summary>
    /// Represents a 3 Axis Digital Accelerometer1_5g Sensor
    /// </summary>
    public class ThreeAxisDigitalAccelerometer1_5g : Mma7660fc
    {
        /// <summary>
        /// Creates a new MoistureSensor driver
        /// </summary>
        /// <param name="i2cBus"></param>
        public ThreeAxisDigitalAccelerometer1_5g(II2cBus i2cBus)
            : base(i2cBus, Addresses.Address_0x4c)
        { }
    }
}
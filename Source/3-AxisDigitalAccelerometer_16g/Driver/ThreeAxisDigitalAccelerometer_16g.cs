using Meadow.Devices;
using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    public class ThreeAxisDigitalAccelerometer16g : Adxl345
    {
        public ThreeAxisDigitalAccelerometer16g(II2cBus i2CBus)
            : base (i2CBus)
        {

        }
    }
}
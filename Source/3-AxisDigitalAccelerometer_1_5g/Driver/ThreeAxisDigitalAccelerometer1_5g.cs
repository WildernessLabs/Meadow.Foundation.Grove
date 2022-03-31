using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    public class ThreeAxisDigitalAccelerometer1_5g : Mma7660fc
    {
        public ThreeAxisDigitalAccelerometer1_5g(II2cBus i2cBus)
            : base (i2cBus, Addresses.Address_0x4c)
        { }
    }
}
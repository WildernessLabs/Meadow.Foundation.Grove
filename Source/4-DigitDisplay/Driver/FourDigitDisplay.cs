using Meadow.Devices;
using Meadow.Foundation.Displays;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Displays
{
    public class FourDigitDisplay : Tm1637
    {
        public FourDigitDisplay(IMeadowDevice device, IPin pinClock, IPin pinData) : base(device, pinClock, pinData)
        {
        }
    }
}
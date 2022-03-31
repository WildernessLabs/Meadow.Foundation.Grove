using Meadow.Foundation.Leds;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Leds
{
    public class LEDSocket : Led
    {
        public LEDSocket(IDigitalOutputPort port)
            : base(port)
        { }

        public LEDSocket(IDigitalOutputController device, IPin pin)
            : base(device, pin)
        { }
    }
}
using Meadow.Foundation.Leds;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Leds
{
    /// <summary>
    /// Represents an LED
    /// </summary>
    public class LEDSocket : Led
    {
        /// <summary>
        /// Creates an LEDSocker driver
        /// </summary>
        /// <param name="port"></param>
        public LEDSocket(IDigitalOutputPort port)
            : base(port)
        { }

        /// <summary>
        /// Creates an LEDSocker driver 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pin"></param>
        public LEDSocket(IDigitalOutputController device, IPin pin)
            : base(device, pin)
        { }
    }
}
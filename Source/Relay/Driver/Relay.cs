using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Relays
{
    /// <summary>
    /// Represents a Relay
    /// </summary>
    public class Relay : Foundation.Relays.Relay
    {
        /// <summary>
        /// Creates a new Relay driver
        /// </summary>
        /// <param name="port"></param>
        public Relay(IDigitalOutputPort port)
            : base(port)
        { }

        /// <summary>
        /// Creates a new Relay driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pin"></param>
        public Relay(IDigitalOutputController device, IPin pin) 
            : base(device, pin)
        { }
    }
}
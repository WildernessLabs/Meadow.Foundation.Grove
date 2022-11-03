using Meadow.Foundation.Audio;
using Meadow.Hardware;
using Meadow.Units;

namespace Meadow.Foundation.Grove.Audio
{
    /// <summary>
    /// Represents a Buzzer
    /// </summary>
    public class Buzzer : PiezoSpeaker
    {
        /// <summary>
        /// Creates a new Buzzer driver
        /// </summary>
        /// <param name="port">The PwmPort used to drive the Buzzer</param>
        public Buzzer(IPwmPort port)
            : base(port)
        { }

        /// <summary>
        /// Creates a new Buzzer driver
        /// </summary>
        /// <param name="device">The Pwm controller connected to the buzzer (typically Meadow)</param>
        /// <param name="pin">The pin connected to the buzzer/param>
        public Buzzer(
            IPwmOutputController device, 
            IPin pin)
            : base(device, pin, new Frequency(440))
        { }
    }
}
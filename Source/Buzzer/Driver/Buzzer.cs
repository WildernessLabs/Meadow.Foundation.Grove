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
        /// <param name="pin">The pin connected to the buzzer</param>
        public Buzzer(
            IPin pin)
            : base(pin, new Frequency(440))
        { }
    }
}

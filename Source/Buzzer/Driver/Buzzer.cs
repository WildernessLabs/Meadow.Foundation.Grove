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
        /// <param name="port"></param>
        public Buzzer(IPwmPort port)
            : base(port)
        { }

        /// <summary>
        /// Creates a new Buzzer driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pin"></param>
        /// <param name="frequency"></param>
        /// <param name="dutyCycle"></param>
        public Buzzer(
            IPwmOutputController device, 
            IPin pin, 
            Frequency frequency, 
            float dutyCycle = 0)
            : base(device, pin, frequency, dutyCycle)
        { }
    }
}
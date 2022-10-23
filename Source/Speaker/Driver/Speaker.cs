using Meadow.Foundation.Audio;
using Meadow.Hardware;
using Meadow.Units;

namespace Meadow.Foundation.Grove.Audio
{
    /// <summary>
    /// Represents a Speaker
    /// </summary>
    public class Speaker : PiezoSpeaker
    {
        /// <summary>
        /// Creates a Speaker driver
        /// </summary>
        /// <param name="port"></param>
        public Speaker(IPwmPort port)
            : base(port)
        { }

        /// <summary>
        /// Creates a Speaker driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pin"></param>
        /// <param name="frequency"></param>
        /// <param name="dutyCycle"></param>
        public Speaker(
            IPwmOutputController device, 
            IPin pin, 
            Frequency frequency, 
            float dutyCycle = 0)
            : base(
                device, 
                pin, 
                frequency, 
                dutyCycle)
        { }
    }
}
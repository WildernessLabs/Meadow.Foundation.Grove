using Meadow.Foundation.Audio;
using Meadow.Hardware;

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
        /// <param name="device"></param>
        /// <param name="pin"></param>
        /// <param name="frequency"></param>
        /// <param name="dutyCycle"></param>
        public Speaker(
            IPwmOutputController device, 
            IPin pin, 
            float frequency = 100, 
            float dutyCycle = 0)
            : base(
                  device, 
                  pin, 
                  frequency, 
                  dutyCycle)
        { }

        /// <summary>
        /// Creates a Speaker driver
        /// </summary>
        /// <param name="port"></param>
        public Speaker(IPwmPort port)
            : base(port)
        { }
    }
}
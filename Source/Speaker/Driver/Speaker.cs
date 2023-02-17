using Meadow.Foundation.Audio;
using Meadow.Hardware;
using Meadow.Units;
using System;
using System.Threading;

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
        /// <param name="pin">The pin connected to the buzzer/param>
        public Speaker(IPin pin)
            : base(pin, new Frequency(440), 0f)
        { }
    }
}
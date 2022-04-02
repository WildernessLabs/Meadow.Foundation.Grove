using Meadow.Devices;
using Meadow.Foundation.Displays;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Displays
{
    /// <summary>
    /// Represents a Four Digit Display Sensor
    /// </summary>
    public class FourDigitDisplay : Tm1637
    {
        /// <summary>
        /// Creates a new FourDigitDisplay driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pinClock"></param>
        /// <param name="pinData"></param>
        public FourDigitDisplay(IMeadowDevice device, IPin pinClock, IPin pinData) 
            : base(device, pinClock, pinData)
        { }
    }
}
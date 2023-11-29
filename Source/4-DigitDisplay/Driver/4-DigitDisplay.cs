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
        /// <param name="pinClock"></param>
        /// <param name="pinData"></param>
        public FourDigitDisplay(IPin pinClock, IPin pinData)
            : base(pinClock, pinData)
        { }
    }
}
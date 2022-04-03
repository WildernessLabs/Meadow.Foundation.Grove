using Meadow.Foundation.RTCs;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.RTCs
{
    /// <summary>
    /// Represents a Real Time Clock (RTC)
    /// </summary>
    public class RTC : Ds1307
    {
        /// <summary>
        /// Creates an RTC driver
        /// </summary>
        /// <param name="bus"></param>
        public RTC(II2cBus bus)
            : base(bus)
        { }
    }
}
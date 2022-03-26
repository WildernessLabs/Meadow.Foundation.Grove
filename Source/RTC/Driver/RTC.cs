using Meadow.Foundation.RTCs;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.RTCs
{
    public class RTC : Ds1307
    {
        public RTC(II2cBus bus) : base(bus)
        {
        }
    }
}

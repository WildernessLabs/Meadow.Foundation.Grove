using Meadow.Foundation.Sensors.Switches;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    public class TiltSwitch : SpdtSwitch
    {
        public TiltSwitch(IDigitalInputController device, IPin pin) 
            : base(device, pin, InterruptMode.EdgeBoth, ResistorMode.InternalPullDown, 50, 2)
        {
        }
    }
}
using Meadow.Foundation.Sensors.Switches;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    public class SwitchP : SpdtSwitch
    {
        public SwitchP(IDigitalInputController device, IPin pin) 
            : base(device, pin, InterruptMode.EdgeBoth, ResistorMode.InternalPullDown, 20, 0)
        {
        }
    }
}
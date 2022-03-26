using Meadow.Foundation.Sensors.Switches;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    public class Tilt : SpdtSwitch
    {
        public Tilt(IDigitalInputController device, IPin pin) 
            : base(device, pin, InterruptMode.EdgeBoth, ResistorMode.InternalPullDown, 50, 2)
        {
        }
    }
}
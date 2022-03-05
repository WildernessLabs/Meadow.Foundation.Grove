using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    public class Touch : PushButton
    {
        public Touch(IDigitalInputController device, IPin inputPin)
            : base(device, inputPin, ResistorMode.InternalPullDown)
        {
        }
    }
}

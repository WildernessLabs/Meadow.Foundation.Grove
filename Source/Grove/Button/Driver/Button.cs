using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    public class Button : PushButton
    {
        public Button (IDigitalInputController device, IPin inputPin)
            : base(device, inputPin, ResistorMode.InternalPullDown)
        {
        }
    }
}
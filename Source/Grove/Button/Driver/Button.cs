using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    public class Button : PushButton
    {
        public Button(IDigitalInputPort interruptPort) : base(interruptPort)
        {
        }

        public Button(IDigitalInputController device, IPin inputPin, ResistorMode resistorMode = ResistorMode.InternalPullUp) : base(device, inputPin, resistorMode)
        {
        }
    }
}
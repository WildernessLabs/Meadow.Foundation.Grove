using Meadow.Devices;
using Meadow.Foundation.Leds;
using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    public class LEDButton : PushButton
    {
        readonly Led led;

        public bool IsLedOn
        {
            get => led.IsOn;
            set => led.IsOn = value;
        }

        public LEDButton(IDigitalInputPort buttonPort, IDigitalOutputPort ledPort) : base(buttonPort)
        {
            led = new Led(ledPort); 
        }

        public LEDButton(IMeadowDevice device, IPin buttonPin, IPin ledPin, ResistorMode resistorMode = ResistorMode.InternalPullUp)
            : base(device, buttonPin, resistorMode)
        {
            led = new Led(device, ledPin);
        }
    }
}
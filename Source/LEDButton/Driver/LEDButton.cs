using Meadow.Devices;
using Meadow.Foundation.Leds;
using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    public class LEDButton : PushButton
    {
        PwmLed Led;

        public bool IsLedOn
        {
            get => Led.IsOn;
            set => Led.IsOn = value;
        }

        public LEDButton(IDigitalInputPort buttonPort, IPwmPort ledPort) : base(buttonPort)
        {
            Led = new PwmLed(ledPort, 3.3f); 
        }

        public LEDButton(IMeadowDevice device, IPin buttonPin, IPin ledPwmPin, ResistorMode resistorMode = ResistorMode.InternalPullUp) : base(device, buttonPin, resistorMode)
        {
            Led = new PwmLed(device.CreatePwmPort(ledPwmPin), 3.3f);
        }
    }
}
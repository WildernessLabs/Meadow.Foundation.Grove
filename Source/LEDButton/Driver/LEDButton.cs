using Meadow.Devices;
using Meadow.Foundation.Leds;
using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    public class LEDButton : PushButton
    {
        Led Led;

        public bool IsLedOn
        {
            get => Led.IsOn;
            set => Led.IsOn = value;
        }

        public LEDButton(IDigitalInputPort buttonPort, IDigitalOutputPort ledPort) : base(buttonPort)
        {
            Led = new Led(ledPort); 
        }

        public LEDButton(IMeadowDevice device, IPin buttonPin, IPin ledPwmPin, ResistorMode resistorMode = ResistorMode.InternalPullUp) : base(device, buttonPin, resistorMode)
        {
            Led = new Led(device.CreateDigitalOutputPort(ledPwmPin));
        }

        
    }
}
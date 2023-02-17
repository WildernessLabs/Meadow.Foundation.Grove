using Meadow.Foundation.Leds;
using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    /// <summary>
    /// Represents an LED button 
    /// </summary>
    public class LEDButton : PushButton
    {
        readonly Led led;

        /// <summary>
        /// Gets/Sets the status of the LED when is on(true) or off(false) 
        /// </summary>
        public bool IsLedOn
        {
            get => led.IsOn;
            set => led.IsOn = value;
        }

        /// <summary>
        /// Creates an LEDButton driver
        /// </summary>
        /// <param name="buttonPort"></param>
        /// <param name="ledPort"></param>
        public LEDButton(IDigitalInputPort buttonPort, IDigitalOutputPort ledPort) 
            : base(buttonPort)
        {
            led = new Led(ledPort); 
        }

        /// <summary>
        /// Creates an LEDButton driver
        /// </summary>
        /// <param name="buttonPin"></param>
        /// <param name="ledPin"></param>
        /// <param name="resistorMode"></param>
        public LEDButton(IPin buttonPin, 
            IPin ledPin, 
            ResistorMode resistorMode = ResistorMode.InternalPullUp)
            : base(buttonPin, resistorMode)
        {
            led = new Led(ledPin);
        }
    }
}
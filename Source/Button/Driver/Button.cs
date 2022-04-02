using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    /// <summary>
    /// Represents a Push Button
    /// </summary>
    public class Button : PushButton
    {
        /// <summary>
        /// Creates a new Button driver
        /// </summary>
        /// <param name="interruptPort"></param>
        public Button(IDigitalInputPort interruptPort) 
            : base(interruptPort)
        { }

        /// <summary>
        /// Creates a new Button driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="inputPin"></param>
        /// <param name="resistorMode"></param>
        public Button(
            IDigitalInputController device, 
            IPin inputPin, 
            ResistorMode resistorMode = ResistorMode.InternalPullUp) 
            : base(device, inputPin, resistorMode)
        { }
    }
}
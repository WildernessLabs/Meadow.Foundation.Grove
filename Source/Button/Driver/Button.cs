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
        public Button(IDigitalInterruptPort interruptPort)
            : base(interruptPort)
        { }

        /// <summary>
        /// Creates a new Button driver
        /// </summary>
        /// <param name="inputPin"></param>
        /// <param name="resistorMode"></param>
        public Button(
            IPin inputPin,
            ResistorMode resistorMode = ResistorMode.InternalPullUp)
            : base(inputPin, resistorMode)
        { }
    }
}
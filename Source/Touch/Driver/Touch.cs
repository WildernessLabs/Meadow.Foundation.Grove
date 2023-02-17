using Meadow.Foundation.Sensors.Buttons;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Buttons
{
    /// <summary>
    /// Represents a Touch button
    /// </summary>
    public class Touch : PushButton
    {
        /// <summary>
        /// Creates a Touch button driver
        /// </summary>
        /// <param name="inputPin"></param>
        public Touch(IPin inputPin)
            : base(inputPin, ResistorMode.InternalPullDown)
        { }
    }
}
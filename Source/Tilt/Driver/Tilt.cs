using Meadow.Foundation.Sensors.Switches;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    /// <summary>
    /// Represents a Tilt
    /// </summary>
    public class Tilt : SpdtSwitch
    {
        /// <summary>
        /// Creates a Tilt driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pin"></param>
        public Tilt(
            IDigitalInputController device, 
            IPin pin) 
            : base(
                  device, 
                  pin, 
                  InterruptMode.EdgeBoth, 
                  ResistorMode.InternalPullDown, 
                  50, 
                  2)
        { }
    }
}
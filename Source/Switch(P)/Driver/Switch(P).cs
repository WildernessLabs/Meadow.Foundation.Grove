using Meadow.Foundation.Sensors.Switches;
using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Switches
{
    /// <summary>
    /// Represents a SwitchP
    /// </summary>
    public class SwitchP : SpdtSwitch
    {
        /// <summary>
        /// Creates a SwitchP driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pin"></param>
        public SwitchP(
            IDigitalInputController device, 
            IPin pin) 
            : base(
                device, 
                pin, 
                InterruptMode.EdgeBoth, 
                ResistorMode.InternalPullDown,
                TimeSpan.FromMilliseconds(20),
                TimeSpan.Zero)
        { }
    }
}
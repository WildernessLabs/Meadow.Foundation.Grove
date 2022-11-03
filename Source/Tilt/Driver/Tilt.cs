﻿using Meadow.Foundation.Sensors.Switches;
using Meadow.Hardware;
using System;

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
                  TimeSpan.FromMilliseconds(50),
                  TimeSpan.FromMilliseconds(2))
        { }
    }
}
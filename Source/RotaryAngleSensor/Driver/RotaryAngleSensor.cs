﻿using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Grove.Sensors.Rotary
{
    /// <summary>
    /// Represents a rotary angle sensor
    /// </summary>
    public class RotaryAngleSensor : AnalogSamplingBase
    {
        /// <summary>
        /// Creates a new RotaryAngleSensor driver
        /// </summary>
        /// <param name="port"></param>
        public RotaryAngleSensor(IAnalogInputPort port) : base(port)
        { }

        /// <summary>
        /// Creates a new RotaryAngleSensor driver
        /// </summary>
        /// <param name="pin">AnalogChannel connected to the sensor.</param>
        public RotaryAngleSensor(IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? voltage = null)
            : this(pin.CreateAnalogInputPort(sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), voltage ?? new Voltage(3.3)))
        { }
    }
}
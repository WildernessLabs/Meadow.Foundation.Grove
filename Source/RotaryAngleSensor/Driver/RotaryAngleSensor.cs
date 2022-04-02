using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Sensors.Rotary
{
    /// <summary>
    /// Represents a rotary angle sensor
    /// </summary>
    public class RotaryAngleSensor : AnalogObservableBase
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
        public RotaryAngleSensor(IAnalogInputController device, IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? voltage = null)
            : this(device.CreateAnalogInputPort(pin, sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), voltage ?? new Voltage(3.3)))
        { }
    }
}
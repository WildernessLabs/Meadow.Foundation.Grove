using Meadow.Foundation.Sensors.Base;
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
        /// <param name="sampleCount">The number of samples to take during each reading.</param>
        /// <param name="sampleInterval">The interval between each sample.</param>
        /// <param name="referenceVoltage">The reference voltage for the analog input port.</param>
        public RotaryAngleSensor(IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? referenceVoltage = null)
            : this(pin.CreateAnalogInputPort(sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), referenceVoltage ?? new Voltage(3.3)))
        { }
    }
}
using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Grove.Sensors.Temperature
{
    /// <summary>
    /// Represents a Temperature Sensor
    /// </summary>
    public class TemperatureSensor : AnalogSamplingBase
    {
        /// <summary>
        /// Creates a new TemperatureSensor driver
        /// </summary>
        /// <param name="pin">Analog pin connected to the sensor.</param>
        /// <param name="sampleCount">The number of samples to take during each reading.</param>
        /// <param name="sampleInterval">The interval between each sample.</param>
        /// <param name="referenceVoltage">The reference voltage for the analog input port.</param>
        public TemperatureSensor(IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? referenceVoltage = null)
            : this(pin.CreateAnalogInputPort(sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), referenceVoltage ?? new Voltage(3.3)))
        { }

        /// <summary>
        /// Creates a new TemperatureSensor driver
        /// </summary>
        /// <param name="port">Analog port connected to the sensor</param>
        public TemperatureSensor(IAnalogInputPort port) : base(port)
        { }
    }
}
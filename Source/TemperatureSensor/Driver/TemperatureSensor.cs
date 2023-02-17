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
        /// <param name="pin">AnalogChannel connected to the sensor.</param>
        public TemperatureSensor(IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? voltage = null)
            : this(pin.CreateAnalogInputPort(sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), voltage ?? new Voltage(3.3)))
        { }

        /// <summary>
        /// Creates a new TemperatureSensor driver
        /// </summary>
        /// <param name="port"></param>
        public TemperatureSensor(IAnalogInputPort port) : base(port)
        { }
    }
}
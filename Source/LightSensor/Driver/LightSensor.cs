using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Grove.Sensors.Light
{
    /// <summary>
    /// Represents a Light Sensor
    /// </summary>
    public class LightSensor : AnalogSamplingBase
    {
        /// <summary>
        /// Creates a new LightSensor driver
        /// </summary>
        /// <param name="port"></param>
        public LightSensor(IAnalogInputPort port) : base(port)
        { }

        /// <summary>
        /// Creates a new LightSensor driver
        /// </summary>
        public LightSensor(
            IAnalogInputController device, 
            IPin pin, 
            int sampleCount = 5, 
            TimeSpan? sampleInterval = null, 
            Voltage? voltage = null)
            : this (
                  device.CreateAnalogInputPort(
                      pin, 
                      sampleCount, 
                      sampleInterval ?? TimeSpan.FromMilliseconds(40), 
                      voltage ?? new Voltage(3.3)))
        { }
    }
}
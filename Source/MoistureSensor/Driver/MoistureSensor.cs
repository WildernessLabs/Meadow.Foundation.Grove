using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Grove.Sensors.Moisture
{
    /// <summary>
    /// Represents a Moisture Sensor
    /// </summary>
    public class MoistureSensor : AnalogObservableBase
    {
        /// <summary>
        /// Creates a new MoistureSensor driver
        /// </summary>
        /// <param name="port"></param>
        public MoistureSensor(IAnalogInputPort port)
            : base(port)
        { }

        /// <summary>
        /// Creates a new MoistureSensor driver
        /// </summary>
        /// <param name="pin">AnalogChannel connected to the sensor.</param>
        public MoistureSensor(
            IAnalogInputController device, 
            IPin pin, 
            int sampleCount = 5, 
            TimeSpan? sampleInterval = null, 
            Voltage? voltage = null)
            : this(
                  device.CreateAnalogInputPort(
                      pin, 
                      sampleCount, 
                      sampleInterval ?? TimeSpan.FromMilliseconds(40), 
                      voltage ?? new Voltage(3.3)))
        { }
    }
}
using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Grove.Sensors.Sound
{
    /// <summary>
    /// Represents a Sound Sensor
    /// </summary>
    public class SoundSensor : AnalogSamplingBase
    {
        /// <summary>
        /// Creates a new SoundSensor driver
        /// </summary>
        /// <param name="pin">AnalogChannel connected to the sensor.</param>
        public SoundSensor(IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? voltage = null)
            : this(pin.CreateAnalogInputPort(sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), voltage ?? new Voltage(3.3)))
        { }

        /// <summary>
        /// Creates a new SoundSensor driver
        /// </summary>
        /// <param name="port"></param>
        public SoundSensor(IAnalogInputPort port) : base(port)
        { }
    }
}
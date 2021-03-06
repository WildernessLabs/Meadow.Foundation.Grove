using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Grove.Sensors.Sound
{
    /// <summary>
    /// Represents a Sound Sensor
    /// </summary>
    public class SoundSensor : AnalogObservableBase
    {
        /// <summary>
        /// Creates a new SoundSensor driver
        /// </summary>
        /// <param name="pin">AnalogChannel connected to the sensor.</param>
        public SoundSensor(IAnalogInputController device, IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? voltage = null)
            : this(device.CreateAnalogInputPort(pin, sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), voltage ?? new Voltage(3.3)))
        { }

        /// <summary>
        /// Creates a new SoundSensor driver
        /// </summary>
        /// <param name="port"></param>
        public SoundSensor(IAnalogInputPort port) : base(port)
        { }
    }
}
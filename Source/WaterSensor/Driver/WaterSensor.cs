using Meadow.Foundation.Sensors.Environmental;
using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Environmental
{
    /// <summary>
    /// Represents a water sensor that can detect the level of water.
    /// </summary>
    public class WaterSensor : AnalogWaterLevel
    {
        /// <summary>
        /// Initializes a new instance of the WaterSensor class using a specified analog input port.
        /// </summary>
        /// <param name="analogInputPort">The analog input port to read water level data from.</param>
        /// <param name="calibration">Optional calibration parameter for the sensor. If null, default calibration is used.</param>
        public WaterSensor(IAnalogInputPort analogInputPort, Calibration? calibration = null)
            : base(analogInputPort, calibration)
        { }

        /// <summary>
        /// Initializes a new instance of the WaterSensor class using a specified analog pin.
        /// </summary>
        /// <param name="analogPin">The analog pin to read water level data from.</param>
        /// <param name="calibration">Optional calibration parameter for the sensor. If null, default calibration is used.</param>
        /// <param name="updateInterval">Optional parameter to specify how often the sensor readings are updated. If null, the default update interval is used.</param>
        public WaterSensor(IPin analogPin, Calibration? calibration = null, TimeSpan? updateInterval = null)
            : base(analogPin, calibration, updateInterval)
        { }
    }
}

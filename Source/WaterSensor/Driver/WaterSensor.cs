using Meadow.Foundation.Sensors.Environmental;
using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Environmental
{
    public class WaterSensor : AnalogWaterLevel
    {
        public WaterSensor(IAnalogInputPort analogInputPort, Calibration calibration = null)
            : base(analogInputPort, calibration)
        { }

        public WaterSensor(IPin analogPin, Calibration calibration = null, TimeSpan? updateInterval = null)
            : base(analogPin, calibration, updateInterval)
        { }
    }
}
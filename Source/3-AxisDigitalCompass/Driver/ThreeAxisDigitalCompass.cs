using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    /// <summary>
    /// Represents a 3-Axis Digital Compass Sensor
    /// </summary>
    public class ThreeAxisDigitalCompass : Hmc5883
    {
        /// <summary>
        /// Creates a new ThreeAxisDigitalCompass driver
        /// </summary>
        /// <param name="i2cBus"></param>
        /// <param name="address"></param>
        /// <param name="gain"></param>
        /// <param name="measuringMode"></param>
        /// <param name="outputRate"></param>
        /// <param name="samplesAmount"></param>
        /// <param name="measurementConfig"></param>
        public ThreeAxisDigitalCompass(
            II2cBus i2cBus, byte address = (byte)Addresses.Default,
            GainLevels gain = GainLevels.Gain1090,
            MeasuringModes measuringMode = MeasuringModes.Continuous,
            DataOutputRates outputRate = DataOutputRates.Rate15,
            SampleAmounts samplesAmount = SampleAmounts.One,
            MeasurementConfigurations measurementConfig = MeasurementConfigurations.Normal)
            : base (
                  i2cBus, 
                  address, 
                  gain, 
                  measuringMode, 
                  outputRate, 
                  samplesAmount, 
                  measurementConfig)
        { }
    }
}
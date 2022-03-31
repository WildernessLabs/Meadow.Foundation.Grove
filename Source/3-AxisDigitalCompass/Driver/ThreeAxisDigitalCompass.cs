using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    public class ThreeAxisDigitalCompass : Hmc5883
    {
        public ThreeAxisDigitalCompass(
            II2cBus i2cBus, byte address = (byte)Addresses.Default,
            GainLevels gain = GainLevels.Gain1090,
            MeasuringModes measuringMode = MeasuringModes.Continuous,
            DataOutputRates outputRate = DataOutputRates.Rate15,
            SampleAmounts samplesAmount = SampleAmounts.One,
            MeasurementConfigurations measurementConfig = MeasurementConfigurations.Normal)
            : base (i2cBus, address, gain, measuringMode, outputRate, samplesAmount, measurementConfig)
        { }
    }
}
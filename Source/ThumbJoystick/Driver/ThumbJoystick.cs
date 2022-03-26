using Meadow.Foundation.Sensors.Hid;
using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Hid
{
    public class ThumbJoystick : AnalogJoystick
    {
        public ThumbJoystick(IAnalogInputPort horizontalInputPort, IAnalogInputPort verticalInputPort, JoystickCalibration calibration = null, bool isInverted = false) : base(horizontalInputPort, verticalInputPort, calibration, isInverted)
        {
        }

        public ThumbJoystick(IAnalogInputController device, IPin horizontalPin, IPin verticalPin, JoystickCalibration calibration = null, bool isInverted = false) : base(device, horizontalPin, verticalPin, calibration, isInverted)
        {
        }

        public ThumbJoystick(IAnalogInputController device, IPin horizontalPin, IPin verticalPin, JoystickCalibration calibration, bool isInverted, int sampleCount, TimeSpan sampleInterval) : base(device, horizontalPin, verticalPin, calibration, isInverted, sampleCount, sampleInterval)
        {
        }
    }
}
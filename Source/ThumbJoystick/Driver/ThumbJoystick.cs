using Meadow.Foundation.Sensors.Hid;
using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Hid
{
    /// <summary>
    /// Represents a ThumbJoystick
    /// </summary>
    public class ThumbJoystick : AnalogJoystick
    {
        /// <summary>
        /// Creates a ThumbJoystick driver
        /// </summary>
        /// <param name="horizontalInputPort"></param>
        /// <param name="verticalInputPort"></param>
        /// <param name="calibration"></param>
        /// <param name="isInverted"></param>
        public ThumbJoystick(
            IAnalogInputPort horizontalInputPort, 
            IAnalogInputPort verticalInputPort, 
            JoystickCalibration calibration = null, 
            bool isInverted = false) 
            : base(
                  horizontalInputPort, 
                  verticalInputPort, 
                  calibration, 
                  isInverted)
        { }

        /// <summary>
        /// Creates a ThumbJoystick driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="horizontalPin"></param>
        /// <param name="verticalPin"></param>
        /// <param name="calibration"></param>
        /// <param name="isInverted"></param>
        public ThumbJoystick(
            IAnalogInputController device, 
            IPin horizontalPin, 
            IPin verticalPin, 
            JoystickCalibration calibration = null, 
            bool isInverted = false) 
            : base(
                  device, 
                  horizontalPin, 
                  verticalPin, 
                  calibration, 
                  isInverted)
        { }

        /// <summary>
        /// Creates a ThumbJoystick driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="horizontalPin"></param>
        /// <param name="verticalPin"></param>
        /// <param name="calibration"></param>
        /// <param name="isInverted"></param>
        /// <param name="sampleCount"></param>
        /// <param name="sampleInterval"></param>
        public ThumbJoystick(
            IAnalogInputController device, 
            IPin horizontalPin, 
            IPin verticalPin, 
            JoystickCalibration calibration, 
            bool isInverted, 
            int sampleCount, 
            TimeSpan sampleInterval) 
            : base(
                  device, 
                  horizontalPin, 
                  verticalPin, 
                  calibration, 
                  isInverted, 
                  sampleCount, 
                  sampleInterval)
        { }
    }
}
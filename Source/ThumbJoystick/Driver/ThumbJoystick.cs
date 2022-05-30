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
        /// <param name="device">The `IAnalogInputController` to create the port on.</param>
        /// <param name="horizontalPin"></param>
        /// <param name="verticalPin"></param>
        /// <param name="calibration">Calibration for the joystick.</param>
        public ThumbJoystick(
            IAnalogInputController device,
            IPin horizontalPin,
            IPin verticalPin,
            JoystickCalibration calibration = null)
            : base(
                  device,
                  horizontalPin,
                  verticalPin,
                  calibration)
        { }

        /// <summary>
        /// Creates a ThumbJoystick driver
        /// </summary>
        /// <param name="device">The `IAnalogInputController` to create the port on.</param>
        /// <param name="horizontalPin"></param>
        /// <param name="verticalPin"></param>
        /// <param name="calibration">Calibration for the joystick.</param>
        /// <param name="sampleCount">How many samples to take during a given
        /// reading. These are automatically averaged to reduce noise.</param>
        /// <param name="sampleInterval">The time, in milliseconds,
        /// to wait in between samples during a reading.</param>
        public ThumbJoystick(
            IAnalogInputController device,
            IPin horizontalPin,
            IPin verticalPin,
            JoystickCalibration calibration,
            int sampleCount,
            TimeSpan sampleInterval)
            : base(
                  device,
                  horizontalPin,
                  verticalPin,
                  calibration,
                  sampleCount,
                  sampleInterval)
        { }

        /// <summary>
        /// Creates a ThumbJoystick driver
        /// </summary>
        /// <param name="horizontalInputPort"></param>
        /// <param name="verticalInputPort"></param>
        /// <param name="calibration"></param>
        public ThumbJoystick(
            IAnalogInputPort horizontalInputPort, 
            IAnalogInputPort verticalInputPort, 
            JoystickCalibration calibration = null) 
            : base(
                  horizontalInputPort, 
                  verticalInputPort, 
                  calibration)
        { }
    }
}
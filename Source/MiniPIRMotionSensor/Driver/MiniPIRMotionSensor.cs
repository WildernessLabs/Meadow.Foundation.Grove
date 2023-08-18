using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    /// <summary>
    /// Represents a Mini PIR motion sensor
    /// </summary>
    public class MiniPIRMotionSensor : ParallaxPir
    {
        /// <summary>
        /// Creates a MiniPIRMotionSensor driver
        /// </summary>
        /// <param name="digitalInterruptPort">The port connected to the PIR</param>
        public MiniPIRMotionSensor(IDigitalInterruptPort digitalInterruptPort)
            : base(digitalInterruptPort)
        { }

        /// <summary>
        /// Creates a MiniPIRMotionSensor driver
        /// </summary>
        /// <param name="pin">The pin connected to the PIR sensor</param>
        /// <param name="interruptMode">The interrupt mode of the pin</param>
        /// <param name="resistorMode">The resistor mode of the pin</param>
        /// <param name="debounceDuration">The debounce duration</param>
        /// <param name="glitchDuration">The glitch duration (can typically be set to zero)</param>
        public MiniPIRMotionSensor(
            IPin pin,
            InterruptMode interruptMode,
            ResistorMode resistorMode,
            TimeSpan debounceDuration,
            TimeSpan glitchDuration)
            : base(pin,
                  interruptMode,
                  resistorMode,
                  debounceDuration,
                  glitchDuration)
        { }
    }
}
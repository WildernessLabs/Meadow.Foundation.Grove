using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;
using System;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    /// <summary>
    /// Represents a PIR motion sensor
    /// </summary>
    public class PIRMotionSensor : ParallaxPir
    {
        /// <summary>
        /// Creates a PIRMotionSensor driver
        /// </summary>
        /// <param name="digitalInputPort"></param>
        public PIRMotionSensor(IDigitalInputPort digitalInputPort)
            : base(digitalInputPort)
        { }

        /// <summary>
        /// Creates a PIRMotionSensor driver
        /// </summary>
        /// <param name="device">The Meadow device</param>
        /// <param name="pin">The pin connected to the PIR sensor</param>
        /// <param name="interruptMode">The interrupt mode of the pin</param>
        /// <param name="resistorMode">The resistor mode of the pin</param>
        /// <param name="debounceDuration">The debounce duration</param>
        /// <param name="glitchDuration">The glitch duration (can typically be set to zero)</param>
        public PIRMotionSensor(
            IDigitalInputController device, 
            IPin pin, 
            InterruptMode interruptMode, 
            ResistorMode resistorMode, 
            TimeSpan debounceDuration, 
            TimeSpan glitchDuration) 
            : base(
                  device, 
                  pin, 
                  interruptMode, 
                  resistorMode, 
                  debounceDuration, 
                  glitchDuration)
        { }
    }
}
using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

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
        /// <param name="device"></param>
        /// <param name="pin"></param>
        /// <param name="interruptMode"></param>
        /// <param name="resistorMode"></param>
        /// <param name="debounceDuration"></param>
        /// <param name="glitchFilterCycleCount"></param>
        public PIRMotionSensor(
            IDigitalInputController device, 
            IPin pin, 
            InterruptMode interruptMode, 
            ResistorMode resistorMode, 
            int debounceDuration = 20, 
            int glitchFilterCycleCount = 0) 
            : base(
                  device, 
                  pin, 
                  interruptMode, 
                  resistorMode, 
                  debounceDuration, 
                  glitchFilterCycleCount)
        { }
    }
}
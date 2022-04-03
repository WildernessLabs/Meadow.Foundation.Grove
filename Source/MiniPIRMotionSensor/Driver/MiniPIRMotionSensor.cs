using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

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
        /// <param name="digitalInputPort"></param>
        public MiniPIRMotionSensor(IDigitalInputPort digitalInputPort)
            : base(digitalInputPort)
        { }

        /// <summary>
        /// Creates a MiniPIRMotionSensor driver
        /// </summary>
        /// <param name="device"></param>
        /// <param name="pin"></param>
        /// <param name="interruptMode"></param>
        /// <param name="resistorMode"></param>
        /// <param name="debounceDuration"></param>
        /// <param name="glitchFilterCycleCount"></param>
        public MiniPIRMotionSensor(
            IDigitalInputController device, 
            IPin pin,
            InterruptMode 
            interruptMode, 
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
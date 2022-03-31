using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    public class MiniPIRMotionSensor : ParallaxPir
    {
        public MiniPIRMotionSensor(IDigitalInputPort digitalInputPort)
            : base(digitalInputPort)
        { }

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
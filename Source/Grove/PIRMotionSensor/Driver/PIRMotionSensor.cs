using Meadow.Foundation.Sensors.Motion;
using Meadow.Hardware;

namespace Meadow.Foundation.Grove.Sensors.Motion
{
    public class PIRMotionSensor : ParallaxPir
    {
        public PIRMotionSensor(IDigitalInputController device, IPin pin, InterruptMode interruptMode, ResistorMode resistorMode, int debounceDuration = 20, int glitchFilterCycleCount = 0) : base(device, pin, interruptMode, resistorMode, debounceDuration, glitchFilterCycleCount)
        {
        }
    
        public PIRMotionSensor(IDigitalInputPort digitalInputPort) : base(digitalInputPort)
        {
        }
    }
}

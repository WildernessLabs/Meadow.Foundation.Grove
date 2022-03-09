using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using Meadow.Hardware;
using System;

namespace Grove.MiniPIRMotionSensor_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            var miniPIRMotionSensor = new MiniPIRMotionSensor(Device.CreateDigitalInputPort(Device.Pins.D13, InterruptMode.EdgeBoth, ResistorMode.Disabled));
            miniPIRMotionSensor.OnMotionStart += (sender) => Console.WriteLine($"Motion start  {DateTime.Now}");
            miniPIRMotionSensor.OnMotionEnd += (sender) => Console.WriteLine($"Motion end  {DateTime.Now}");
        }
    }
}
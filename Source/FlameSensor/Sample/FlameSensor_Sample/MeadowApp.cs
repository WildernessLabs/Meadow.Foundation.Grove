using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Environmental;
using System;

namespace Grove.FlameSensor_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var flameSensor = new FlameSensor(Device, Device.Pins.D13);

            flameSensor.FlameDetected += (s, e) => Console.WriteLine($"fire detected: {e}");
        }
    }
}
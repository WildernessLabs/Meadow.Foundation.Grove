using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using System;

namespace Grove.VibrationSensor_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var vibrationSensor = new VibrationSensor(Device, Device.Pins.D13);

            vibrationSensor.VibrationDetected += (s, e) => Console.WriteLine("Motion detected");
        }
    }
}
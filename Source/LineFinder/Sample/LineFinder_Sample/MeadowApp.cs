using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Light;
using System;

namespace Grove.LineFinder_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var lineFinder = new LineFinder(Device, Device.Pins.D13);

            lineFinder.ColorChanged += (s, e) => Console.WriteLine($"line color: {e}");
        }
    }
}
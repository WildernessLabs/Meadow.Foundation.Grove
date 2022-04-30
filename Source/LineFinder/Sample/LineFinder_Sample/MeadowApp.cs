using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Light;
using System;

namespace Grove.LineFinder_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var lineFinder = new LineFinder(Device, Device.Pins.D13);

            lineFinder.ColorChanged += (s, e) => Console.WriteLine($"line color: {e}");
        }

        //<!=SNOP=>
    }
}
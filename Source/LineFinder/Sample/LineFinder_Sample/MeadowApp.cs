using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Light;
using System;
using System.Threading.Tasks;

namespace Grove.LineFinder_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            var lineFinder = new LineFinder(Device.Pins.D13);

            lineFinder.ColorChanged += (s, e) =>
            {
                Console.WriteLine($"line color: {e}");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
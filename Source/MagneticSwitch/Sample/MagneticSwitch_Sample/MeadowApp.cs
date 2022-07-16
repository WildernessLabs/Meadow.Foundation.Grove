using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;
using System.Threading.Tasks;

namespace Grove.FlameSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            var magneticSwitch = new MagneticSwitch(Device, Device.Pins.D13);

            magneticSwitch.Changed += (s, e) =>
            {
                Console.WriteLine($"Switched - open {magneticSwitch.IsOn}");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
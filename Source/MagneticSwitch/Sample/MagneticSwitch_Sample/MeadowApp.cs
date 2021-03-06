using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;

namespace Grove.FlameSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var magneticSwitch = new MagneticSwitch(Device, Device.Pins.D13);

            magneticSwitch.Changed += (s, e) => Console.WriteLine($"Switched - open {magneticSwitch.IsOn}");
        }

        //<!=SNOP=>
    }
}
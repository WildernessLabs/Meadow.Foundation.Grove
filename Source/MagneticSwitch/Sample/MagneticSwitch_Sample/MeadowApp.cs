using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;

namespace Grove.FlameSensor_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var magneticSwitch = new MagneticSwitch(Device, Device.Pins.D13);

            magneticSwitch.Changed += (s, e) => Console.WriteLine($"Switched - open {magneticSwitch.IsOn}");
        }
    }
}
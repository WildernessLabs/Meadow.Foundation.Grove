using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;

namespace Grove.SwitchP_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        //<!—SNIP—>

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var groveSwitch = new SwitchP(Device, Device.Pins.D13);

            groveSwitch.Changed += (s, e) =>
            {
                Console.WriteLine(groveSwitch.IsOn ? "Switch is High" : "Switch is Low");
            };
        }

        //<!—SNOP—>
    }
}
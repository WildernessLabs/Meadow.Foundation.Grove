using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Buttons;
using System;

namespace Grove.Touch_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        //<!—SNIP—>

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            Touch touch = new Touch(Device, Device.Pins.D04);
            touch.LongClickedThreshold = TimeSpan.FromMilliseconds(1500);

            touch.Clicked += (s, e) => Console.WriteLine("Grove Touch pressed");

            touch.LongClicked += (s, e) => Console.WriteLine("Gove Touch long pressed");
        }

        //<!—SNOP—>
    }
}
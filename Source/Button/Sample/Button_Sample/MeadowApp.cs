using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Buttons;
using System;

namespace Grove.Button_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        //<!-SNIP->

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var button = new Button(Device, Device.Pins.D13);
            button.LongClickedThreshold = TimeSpan.FromMilliseconds(1500);

            button.Clicked += (s, e) => Console.WriteLine("Grove Button clicked");

            button.LongClicked += (s, e) => Console.WriteLine("Grove Button long clicked");
        }

        //<!—SNOP—>
    }
}
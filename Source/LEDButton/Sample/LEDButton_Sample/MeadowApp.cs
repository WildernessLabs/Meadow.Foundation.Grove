using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Buttons;
using System;

namespace Grove.LEDButton_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var button = new LEDButton(Device, Device.Pins.D12, Device.Pins.D13);

            button.LongClickedThreshold = TimeSpan.FromMilliseconds(1500);

            button.Clicked += (s, e) =>
            {
                Console.WriteLine("Grove Button clicked");
                button.IsLedOn = !button.IsLedOn;
            };

            button.LongClicked += (s, e) =>
            {
                Console.WriteLine("Grove Button long clicked");
            };
        }

        //<!=SNOP=>
    }
}
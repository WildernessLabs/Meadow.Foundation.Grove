using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Buttons;
using System;
using System.Threading.Tasks;

namespace Grove.LEDButton_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        LEDButton ledButton;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            ledButton = new LEDButton(buttonPin: Device.Pins.D12, ledPin: Device.Pins.D13);

            ledButton.LongClickedThreshold = TimeSpan.FromMilliseconds(1500);

            ledButton.Clicked += (s, e) =>
            {
                Console.WriteLine("Grove Button clicked");
                ledButton.IsLedOn = !ledButton.IsLedOn;
            };

            ledButton.LongClicked += (s, e) =>
            {
                Console.WriteLine("Grove Button long clicked");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
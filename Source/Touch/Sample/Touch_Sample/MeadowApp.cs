using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Buttons;
using System;
using System.Threading.Tasks;

namespace Grove.Touch_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        Touch touch;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            touch = new Touch(Device.Pins.D04);
            touch.LongClickedThreshold = TimeSpan.FromMilliseconds(1500);

            touch.Clicked += (s, e) =>
            {
                Console.WriteLine("Grove Touch pressed");
            };

            touch.LongClicked += (s, e) =>
            {
                Console.WriteLine("Grove Touch long pressed");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
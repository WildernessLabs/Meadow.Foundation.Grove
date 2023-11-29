using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Buttons;
using System;
using System.Threading.Tasks;

namespace Grove.Button_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        Button button;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            button = new Button(Device.Pins.D13)
            {
                LongClickedThreshold = TimeSpan.FromMilliseconds(1500)
            };

            button.Clicked += (s, e) => Resolver.Log.Info("Grove Button clicked");

            button.LongClicked += (s, e) => Resolver.Log.Info("Grove Button long clicked");

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
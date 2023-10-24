using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Displays;
using Meadow.Foundation.Grove.Displays;
using System;
using System.Threading.Tasks;

namespace Grove.FourDigitDisplay_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        FourDigitDisplay display;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initializing ...");

            display = new FourDigitDisplay(
                device: Device,
                pinClock: Device.Pins.D02,
                pinData: Device.Pins.D01)
            {
                Brightness = 7,
                ScreenOn = true
            };

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            display.Clear();

            var chars = new Character[] { Character.A, Character.B, Character.C, Character.D };

            display.Show(chars);

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
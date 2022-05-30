using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Displays;
using Meadow.Foundation.Grove.Displays;
using System;

namespace Grove.FourDigitDisplay_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        FourDigitDisplay display;
        
        public MeadowApp()
        {
            Console.WriteLine("Initializing ...");

            display = new FourDigitDisplay(Device, Device.Pins.D02, Device.Pins.D01);

            display.Brightness = 7;
            display.ScreenOn = true;

            display.Clear();

            var chars = new Character[] { Character.A, Character.B, Character.C, Character.D };

            display.Show(chars);
        }

        //<!=SNOP=>
    }
}
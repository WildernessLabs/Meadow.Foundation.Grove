using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Displays;
using Meadow.Foundation.Grove.Displays;
using System;

namespace Grove.FourDigitDisplay_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
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
    }
}
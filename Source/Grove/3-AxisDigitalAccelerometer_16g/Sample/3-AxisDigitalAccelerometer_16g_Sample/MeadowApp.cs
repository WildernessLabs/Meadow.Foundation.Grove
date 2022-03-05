using Meadow;
using Meadow.Devices;
using System;

namespace Grove.FourDigitDisplay_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initializing ...");

        }
    }
}
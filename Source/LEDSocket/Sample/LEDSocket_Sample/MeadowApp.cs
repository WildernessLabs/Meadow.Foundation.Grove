using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Leds;
using System;

namespace Grove.LEDSocket_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        public MeadowApp()
        {
            

            Console.WriteLine("Initialize hardware...");

            LEDSocket led = new LEDSocket(Device, Device.Pins.D13);

            led.StartBlink();
        }

        //<!=SNOP=>
    }
}
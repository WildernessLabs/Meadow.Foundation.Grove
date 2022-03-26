using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Leds;
using System;

namespace Grove.LEDSocket_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            LEDSocket led = new LEDSocket(Device, Device.Pins.D13);

            led.StartBlink();
        }
    }
}
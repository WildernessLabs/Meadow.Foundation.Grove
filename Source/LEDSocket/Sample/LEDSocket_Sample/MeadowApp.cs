using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Leds;
using System;
using System.Threading.Tasks;

namespace Grove.LEDSocket_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        LEDSocket led;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            led = new LEDSocket(Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            led.StartBlink();

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
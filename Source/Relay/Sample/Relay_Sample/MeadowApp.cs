using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Relays;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Relay_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        Relay relay;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            relay = new Relay(Device, Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            var state = false;

            while (true)
            {
                state = !state;

                Console.WriteLine($"- State: {state}");
                relay.IsOn = state;

                await Task.Delay(500);
            }
        }

        //<!=SNOP=>
    }
}
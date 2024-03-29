﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Relays;
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
            Resolver.Log.Info("Initialize...");

            relay = new Relay(Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            var state = false;

            while (true)
            {
                state = !state;

                Resolver.Log.Info($"- State: {state}");

                relay.State = state
                    ? Meadow.Peripherals.Relays.RelayState.Closed
                    : Meadow.Peripherals.Relays.RelayState.Open;

                await Task.Delay(500);
            }
        }

        //<!=SNOP=>
    }
}
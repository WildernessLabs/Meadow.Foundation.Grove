using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Relays;
using System;
using System.Threading;

namespace Relay_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!-SNIP->

        Relay relay;

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            relay = new Relay(Device, Device.Pins.D13);

            TestRelay();
        }

        void TestRelay()
        {
            Console.WriteLine("TestRelay...");

            var state = false;

            while (true)
            {
                state = !state;

                Console.WriteLine($"- State: {state}");
                relay.IsOn = state;

                Thread.Sleep(500);
            }
        }

        //<!—SNOP—>
    }
}
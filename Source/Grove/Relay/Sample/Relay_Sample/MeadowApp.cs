using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Relays;
using System;
using System.Threading;

namespace Relay_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
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
    }
}
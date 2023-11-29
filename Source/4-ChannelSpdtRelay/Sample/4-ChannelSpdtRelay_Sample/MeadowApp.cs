using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Relays;
using System.Threading;
using System.Threading.Tasks;
using static Meadow.Foundation.Grove.Relays.FourChannelSpdtRelay;

namespace Grove.FourChannelSpdtRelay_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7CoreComputeV2>
    {
        //<!=SNIP=>

        FourChannelSpdtRelay module;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initializing ...");

            module = new FourChannelSpdtRelay(Device.CreateI2cBus(), 0x11);

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Resolver.Log.Info("All on");
                module.SetAllOn();

                Thread.Sleep(1000);

                Resolver.Log.Info("All off");
                module.SetAllOff();

                Thread.Sleep(1000);

                for (int j = 0; j < 4; j++)
                {
                    Resolver.Log.Info($"{(RelayIndex)j} on");
                    module.Relays[j].IsOn = true;
                    Thread.Sleep(1000);
                }

                for (int j = 0; j < 4; j++)
                {
                    Resolver.Log.Info($"{(RelayIndex)j} off");
                    module.Relays[j].IsOn = false;
                    Thread.Sleep(1000);
                }
            }

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
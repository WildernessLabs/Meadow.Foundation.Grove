using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Environmental;
using System;
using System.Threading.Tasks;

namespace Grove.FlameSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        FlameSensor flameSensor;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            flameSensor = new FlameSensor(Device.Pins.D13);

            flameSensor.FlameDetected += (s, e) =>
            {
                Resolver.Log.Info($"fire detected: {e}");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;
using System.Threading.Tasks;

namespace Grove.FlameSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            var magneticSwitch = new MagneticSwitch(Device.Pins.D13);

            magneticSwitch.Changed += (s, e) =>
            {
                Resolver.Log.Info($"Switched - open {magneticSwitch.IsOn}");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
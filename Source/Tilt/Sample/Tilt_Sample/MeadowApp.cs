using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;
using System.Threading.Tasks;

namespace Grove.TiltSwitch_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        Tilt tiltSwitch;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            tiltSwitch = new Tilt(Device.Pins.D13);

            tiltSwitch.Changed += (s, e) =>
            {
                Resolver.Log.Info(tiltSwitch.IsOn ? "Switch is High" : "Switch is Low");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
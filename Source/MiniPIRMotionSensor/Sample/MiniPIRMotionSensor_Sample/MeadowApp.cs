using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using Meadow.Hardware;
using System;
using System.Threading.Tasks;

namespace Grove.MiniPIRMotionSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        public override Task Initialize()
        {
            var miniPIRMotionSensor = new MiniPIRMotionSensor(
                Device.CreateDigitalInterruptPort(
                    Device.Pins.D13,
                    InterruptMode.EdgeBoth,
                    ResistorMode.Disabled));

            miniPIRMotionSensor.OnMotionStart += (sender) =>
            {
                Resolver.Log.Info($"Motion start  {DateTime.Now}");
            };

            miniPIRMotionSensor.OnMotionEnd += (sender) =>
            {
                Resolver.Log.Info($"Motion end  {DateTime.Now}");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
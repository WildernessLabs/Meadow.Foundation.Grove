using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using System;
using System.Threading.Tasks;

namespace Grove.VibrationSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        VibrationSensor sensor;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            sensor = new VibrationSensor(Device, Device.Pins.D13);

            sensor.VibrationDetected += (s, e) =>
            {
                Console.WriteLine("Motion detected");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
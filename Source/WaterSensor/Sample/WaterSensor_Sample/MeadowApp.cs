using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Environmental;
using System;
using System.Threading.Tasks;

namespace Grove.WaterSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        WaterSensor waterSensor;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            waterSensor = new WaterSensor(Device.Pins.A01);

            waterSensor.Subscribe(WaterSensor.CreateObserver(
                h => Console.WriteLine($"Water level changed by 10 mm; new: {h.New}, old: {h.Old}"),
                null //e => { return Math.Abs(e.Delta) > 0.1f; }
            ));

            waterSensor.Updated += (object sender, IChangeResult<float> e) =>
            {
                Console.WriteLine($"Level Changed, level: {e.New}cm");
            };

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            var conditions = await waterSensor.Read();
            Console.WriteLine($"Initial level: {conditions}");

            waterSensor.StartUpdating(TimeSpan.FromSeconds(5));
        }

        //<!=SNOP=>
    }
}
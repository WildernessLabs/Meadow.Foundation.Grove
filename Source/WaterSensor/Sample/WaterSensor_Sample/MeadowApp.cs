using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Environmental;
using System;
using System.Threading.Tasks;

namespace Grove.WaterSensor_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        //<!—SNIP—>

        WaterSensor waterSensor;

        public MeadowApp()
        {
            Console.WriteLine("Initializing...");

            // configure our AnalogWaterLevel sensor
            waterSensor = new WaterSensor(
                device: Device,
                analogPin: Device.Pins.A01
            );

            // Example that uses an IObersvable subscription to only be notified
            // when the level changes by at least 0.1cm
            waterSensor.Subscribe(WaterSensor.CreateObserver(
                h => Console.WriteLine($"Water level changed by 10 mm; new: {h.New}, old: {h.Old}"),
                // TODO: revisit this
                null //e => { return Math.Abs(e.Delta) > 0.1f; }
            ));

            // classical .NET events can also be used:
            waterSensor.Updated += (object sender, IChangeResult<float> e) => {
                Console.WriteLine($"Level Changed, level: {e.New}cm");
            };

            // Get an initial reading.
            ReadLevel().Wait();

            // Spin up the sampling thread so that events are raised and
            // IObservable notifications are sent.
            waterSensor.StartUpdating(TimeSpan.FromSeconds(5));
        }

        async Task ReadLevel()
        {
            var conditions = await waterSensor.Read();
            Console.WriteLine($"Initial level: { conditions }");
        }

        //<!—SNOP—>
    }
}
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Moisture;
using System;
using System.Threading.Tasks;

namespace MoistureSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        MoistureSensor sensor;

        public MeadowApp()
        {
            Console.WriteLine("Initializing...");

            // configure our sensor
            sensor = new MoistureSensor(Device, Device.Pins.A01);

            // Example that uses an IObservable subscription to only be notified when the voltage changes by at least 500mV
            var consumer = MoistureSensor.CreateObserver(
                handler: result => Console.WriteLine($"Observer filter satisfied: {result.New.Millivolts:N2}mV, old: {result.Old?.Millivolts:N2}mV"),
                // only notify if the change is greater than 0.5V
                filter: result => 
                {
                    if (result.Old is { } old)
                    { //c# 8 pattern match syntax. checks for !null and assigns var.
                        return (result.New - old).Abs().Millivolts > 500;
                    }
                    return false;
                });

            sensor.Subscribe(consumer);

            // classical .NET events can also be used:
            sensor.Updated += (sender, result) => {
                Console.WriteLine($"Voltage Changed, new: {result.New.Millivolts:N2}mV, old: {result.Old?.Millivolts:N2}mV");
            };

            //==== One-off reading use case/pattern
            ReadMoisture().Wait();

            sensor.StartUpdating(TimeSpan.FromMilliseconds(1000));
        }

        protected async Task ReadMoisture()
        {
            var result = await sensor.Read();
            Console.WriteLine($"Initial read: {result.Millivolts:N2}mV");
        }

        //<!=SNOP=>
    }
}
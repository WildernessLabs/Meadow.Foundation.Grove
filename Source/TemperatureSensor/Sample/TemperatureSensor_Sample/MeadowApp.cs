using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Temperature;
using System;
using System.Threading.Tasks;

namespace TemperatureSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        TemperatureSensor sensor;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            sensor = new TemperatureSensor(Device.Pins.A01);

            var consumer = TemperatureSensor.CreateObserver(
                handler: result => 
                { 
                    Console.WriteLine($"Observer filter satisfied - " +
                        $"new: {result.New.Millivolts:N2}mV, " +
                        $"old: {result.Old?.Millivolts:N2}mV"); 
                },
                filter: result =>
                {
                    if (result.Old is { } old)
                    {   //c# 8 pattern match syntax. checks for !null and assigns var.
                        return (result.New - old).Abs().Millivolts > 500;
                    }
                    return false;
                });
            sensor.Subscribe(consumer);

            sensor.Updated += (sender, result) =>
            {
                Console.WriteLine($"Voltage Changed, new: {result.New.Millivolts:N2}mV, old: {result.Old?.Millivolts:N2}mV");
            };

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            var result = await sensor.Read();
            Console.WriteLine($"Initial read: {result.Millivolts:N2}mV");

            sensor.StartUpdating(TimeSpan.FromMilliseconds(1000));
        }

        //<!=SNOP=>
    }
}
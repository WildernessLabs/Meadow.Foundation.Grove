using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Atmospheric;
using System;

namespace Grove.TemperatureHumiditySensor_HighAccuracyMini_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        //<!—SNIP—>

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var sensor = new TemperatureHumiditySensor_HighAccuracyMini(Device.CreateI2cBus());

            var consumer = TemperatureHumiditySensor_HighAccuracyMini.CreateObserver(
                handler: result =>
                {
                    Console.WriteLine($"Observer: Temp changed by threshold; new temp: {result.New.Temperature?.Celsius:N2}C, old: {result.Old?.Temperature?.Celsius:N2}C");
                },
                filter: result =>
                {
                    //c# 8 pattern match syntax. checks for !null and assigns var.
                    if (result.Old is { } old)
                    {
                        return (
                        (result.New.Temperature.Value - old.Temperature.Value).Abs().Celsius > 0.5);
                    }
                    return false;
                }
            );
            sensor.Subscribe(consumer);

            sensor.Updated += (sender, result) =>
            {
                Console.WriteLine($"  Temperature: {result.New.Temperature?.Celsius:N2}C");
                Console.WriteLine($"  Relative Humidity: {result.New.Humidity?.Percent:N2}%");
            };

            sensor.StartUpdating(TimeSpan.FromSeconds(1));
        }

        //<!—SNOP—>
    }
}
# Meadow.Foundation.Grove.Sensors.Atmospheric.TemperatureHumiditySensor_HighAccuracyMini

**Grove I2C Temperature and Humidity sensor - High Accuracy and Mini (TH02)**

The **TemperatureHumiditySensor_HighAccuracyMini** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
TemperatureHumiditySensor_HighAccuracyMini sensor;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    sensor = new TemperatureHumiditySensor_HighAccuracyMini(Device.CreateI2cBus());

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

    return Task.CompletedTask;
}

public override Task Run()
{
    sensor.StartUpdating(TimeSpan.FromSeconds(1));

    return Task.CompletedTask;
}

```

# Meadow.Foundation.Grove.Sensors.Temperature.TemperatureSensor

**Grove temperature sensor**

The **TemperatureSensor** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
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

```

# Meadow.Foundation.Grove.Sensors.Environmental.FlameSensor

**Grove GPIO flame sensor**

The **FlameSensor** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
FlameSensor flameSensor;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    flameSensor = new FlameSensor(Device.Pins.D13);

    flameSensor.FlameDetected += (s, e) =>
    {
        Console.WriteLine($"fire detected: {e}");
    };

    return Task.CompletedTask;
}

```

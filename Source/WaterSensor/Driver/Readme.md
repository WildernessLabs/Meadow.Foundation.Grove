# Meadow.Foundation.Grove.Sensors.Environmental.WaterSensor

**Grove Analog water level sensor**

The **WaterSensor** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
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

```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).

# Meadow.Foundation.Grove.Sensors.Light.LineFinder

**Grove line finder sensor**

The **LineFinder** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all of Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    var lineFinder = new LineFinder(Device.Pins.D13);

    lineFinder.ColorChanged += (s, e) =>
    {
        Console.WriteLine($"line color: {e}");
    };

    return Task.CompletedTask;
}

        
```


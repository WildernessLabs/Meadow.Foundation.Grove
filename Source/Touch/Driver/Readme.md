# Meadow.Foundation.Grove.Sensors.Buttons.Touch

**Grove GPIO capacitive touch button**

The **Touch** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all of Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
Touch touch;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    touch = new Touch(Device.Pins.D04);
    touch.LongClickedThreshold = TimeSpan.FromMilliseconds(1500);

    touch.Clicked += (s, e) =>
    {
        Console.WriteLine("Grove Touch pressed");
    };

    touch.LongClicked += (s, e) =>
    {
        Console.WriteLine("Grove Touch long pressed");
    };

    return Task.CompletedTask;
}

        
```


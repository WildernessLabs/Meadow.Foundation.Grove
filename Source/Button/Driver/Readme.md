# Meadow.Foundation.Grove.Sensors.Buttons.Button

**Grove GPIO momentary push button**

The **Button** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all of Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
Button button;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    button = new Button(Device.Pins.D13)
    {
        LongClickedThreshold = TimeSpan.FromMilliseconds(1500)
    };

    button.Clicked += (s, e) => Console.WriteLine("Grove Button clicked");

    button.LongClicked += (s, e) => Console.WriteLine("Grove Button long clicked");

    return Task.CompletedTask;
}

        
```


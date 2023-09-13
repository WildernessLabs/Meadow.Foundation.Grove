# Meadow.Foundation.Grove.Sensors.Switches.Tilt

**Grove GPIO tilt switch**

The **Tilt** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
Tilt tiltSwitch;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    tiltSwitch = new Tilt(Device.Pins.D13);

    tiltSwitch.Changed += (s, e) =>
    {
        Console.WriteLine(tiltSwitch.IsOn ? "Switch is High" : "Switch is Low");
    };

    return Task.CompletedTask;
}

```

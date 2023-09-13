# Meadow.Foundation.Grove.Sensors.Switches.SwitchP

**Grove GPIO single pole dual throw slide switch**

The **SwitchP** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
SwitchP groveSwitch;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    groveSwitch = new SwitchP(Device.Pins.D13);

    groveSwitch.Changed += (s, e) =>
    {
        Console.WriteLine(groveSwitch.IsOn ? "Switch is High" : "Switch is Low");
    };

    return Task.CompletedTask;
}

```

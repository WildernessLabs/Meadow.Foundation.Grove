# Meadow.Foundation.Grove.Relays.Relay

**Grove Relay driver**

The **Relay** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
Relay relay;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    relay = new Relay(Device.Pins.D13);

    return Task.CompletedTask;
}

public override async Task Run()
{
    var state = false;

    while (true)
    {
        state = !state;

        Console.WriteLine($"- State: {state}");
        relay.IsOn = state;

        await Task.Delay(500);
    }
}

```

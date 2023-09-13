# Meadow.Foundation.Grove.Leds.LEDSocket

**Grove GPIO led**

The **LEDSocket** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
LEDSocket led;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    led = new LEDSocket(Device.Pins.D13);

    return Task.CompletedTask;
}

public override Task Run()
{
    led.StartBlink();

    return Task.CompletedTask;
}

```

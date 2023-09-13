# Meadow.Foundation.Grove.Displays.4DigitDisplay

**Grove GPIO 4 digit display**

The **4DigitDisplay** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
FourDigitDisplay display;

public override Task Initialize()
{
    Console.WriteLine("Initializing ...");

    display = new FourDigitDisplay(
        device: Device, 
        pinClock: Device.Pins.D02,
        pinData: Device.Pins.D01) 
    { 
        Brightness = 7,
        ScreenOn = true
    };

    return Task.CompletedTask;
}

public override Task Run()
{
    display.Clear();

    var chars = new Character[] { Character.A, Character.B, Character.C, Character.D };

    display.Show(chars);

    return Task.CompletedTask;
}

```

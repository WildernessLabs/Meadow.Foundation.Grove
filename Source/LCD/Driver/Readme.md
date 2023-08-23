# Meadow.Foundation.Grove.Displays.LCD

**Grove I2C LCD display**

The **LCD** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all of Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
LCD display;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    display = new LCD(Device.CreateI2cBus());

    return Task.CompletedTask;
}

public override async Task Run()
{
    display.Write("Hello Grove");

    await Task.Delay(2000);

    for (byte i = 0; i < 16; i++)
    {
        display.SetCursorPosition(i, 0);
        display.Write("1");
        Thread.Sleep(250);

        display.SetCursorPosition(i, 1);
        display.Write("2");
        Thread.Sleep(250);
    }

    display.ClearLines();
}

        
```

# Meadow.Foundation.Grove.Displays.OLEDDisplay112

**Grove I2C OLED 1.12" display**

The **OLEDDisplay112** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
OLEDDisplay1_12inch display;
MicroGraphics graphics;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    display = new OLEDDisplay1_12inch(Device.CreateI2cBus(), OLEDDisplayVersion.Version3x);

    graphics = new MicroGraphics(display)
    {
        CurrentFont = new Font8x8(),
        Rotation = RotationType._180Degrees
    };

    return Task.CompletedTask;
}

public override Task Run()
{
    graphics.Clear();
    graphics.DrawRectangle(0, 0, graphics.Width, graphics.Height, false);
    graphics.DrawTriangle(10, 10, 50, 50, 10, 50, false);
    graphics.DrawRectangle(20, 15, 40, 20, true);
    graphics.DrawText(5, 5, "SH1107");
    graphics.Show();

    return Task.CompletedTask;
}

```

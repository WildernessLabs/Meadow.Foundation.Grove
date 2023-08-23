# Meadow.Foundation.Grove.Sensors.Motion.MiniPIRMotionSensor

**Grove GPIO MiniPIRMotionSensor (Parallax PIR)**

The **MiniPIRMotionSensor** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all of Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
public override Task Initialize()
{
    var miniPIRMotionSensor = new MiniPIRMotionSensor(
        Device.CreateDigitalInterruptPort(
            Device.Pins.D13,
            InterruptMode.EdgeBoth,
            ResistorMode.Disabled));

    miniPIRMotionSensor.OnMotionStart += (sender) =>
    {
        Console.WriteLine($"Motion start  {DateTime.Now}");
    };

    miniPIRMotionSensor.OnMotionEnd += (sender) =>
    {
        Console.WriteLine($"Motion end  {DateTime.Now}");
    };

    return Task.CompletedTask;
}

        
```


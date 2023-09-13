# Meadow.Foundation.Grove.Sensors.Motion.PIRMotionSensor

**Grove GPIO PIRMotionSensor (Parallax PIR)**

The **PIRMotionSensor** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
PIRMotionSensor motionSensor;

public override Task Initialize()
{
    motionSensor = new PIRMotionSensor(
        Device.CreateDigitalInterruptPort(
            Device.Pins.D13,
            InterruptMode.EdgeBoth,
            ResistorMode.Disabled));

    motionSensor.OnMotionStart += (sender) =>
    {
        Console.WriteLine($"Motion start  {DateTime.Now}");
    };

    motionSensor.OnMotionEnd += (sender) =>
    {
        Console.WriteLine($"Motion end  {DateTime.Now}");
    };

    return Task.CompletedTask;
}

```

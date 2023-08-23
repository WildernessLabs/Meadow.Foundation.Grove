# Meadow.Foundation.Grove.Sensors.Hid.ThumbJoystick

**Grove analog 2-axis ThumbJoystick**

The **ThumbJoystick** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all of Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
ThumbJoystick joystick;

public override Task Initialize()
{
    Console.WriteLine("Initializing hardware...");

    joystick = new ThumbJoystick(
        Device.CreateAnalogInputPort(Device.Pins.A01, 1, TimeSpan.FromMilliseconds(10), new Voltage(3.3)),
        Device.CreateAnalogInputPort(Device.Pins.A02, 1, TimeSpan.FromMilliseconds(10), new Voltage(3.3)),
        null);

    joystick.Updated += JoystickUpdated;

    return Task.CompletedTask;
}

public override async Task Run()
{
    await joystick.SetCenterPosition();

    joystick.StartUpdating(TimeSpan.FromMilliseconds(20));
}

private void JoystickUpdated(object sender, IChangeResult<AnalogJoystickPosition> e)
{
    Console.WriteLine($"Horizontal: {e.New.Horizontal:n2}, Vertical: {e.New.Vertical:n2}");
    Console.WriteLine($"Digital position: {joystick.DigitalPosition}");
}

        
```


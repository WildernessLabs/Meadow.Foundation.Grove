# Meadow.Foundation.Grove.Sensors.Motion.3-AxisDigitalAccelerometer1_5g

**Grove I2C 3-Axis digital accelerometer**

The **3-AxisDigitalAccelerometer1_5g** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all of Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
ThreeAxisDigitalAccelerometer1_5g sensor;

public override Task Initialize()
{
    Console.WriteLine("Initializing");

    // create the sensor driver
    sensor = new ThreeAxisDigitalAccelerometer1_5g(Device.CreateI2cBus());

    // classical .NET events can also be used:
    sensor.Updated += (sender, result) => {
        Console.WriteLine($"Accel: [X:{result.New.X.MetersPerSecondSquared:N2}," +
            $"Y:{result.New.Y.MetersPerSecondSquared:N2}," +
            $"Z:{result.New.Z.MetersPerSecondSquared:N2} (m/s^2)]" +
            $" Direction: {sensor.Direction}" +
            $" Orientation: {sensor.Orientation}");
    };

    // Example that uses an IObersvable subscription to only be notified when the filter is satisfied
    var consumer = ThreeAxisDigitalAccelerometer1_5g.CreateObserver(
        handler: result => Console.WriteLine($"Observer: [x] changed by threshold; new [x]: X:{result.New.X:N2}, old: X:{result.Old?.X:N2}"),
        // only notify if there's a greater than 0.5G change in the Z direction
        filter: result => {
            if (result.Old is { } old)
            { //c# 8 pattern match syntax. checks for !null and assigns var.
                return (result.New - old).Z > new Acceleration(0.5, AU.Gravity);
            }
            return false;
        });
    sensor.Subscribe(consumer);

    return Task.CompletedTask;
}

public override Task Run()
{
    sensor.StartUpdating(TimeSpan.FromMilliseconds(1000));

    return Task.CompletedTask;
}

        
```


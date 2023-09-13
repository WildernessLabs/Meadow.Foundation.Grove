# Meadow.Foundation.Grove.Sensors.Motion.3-AxisDigitalAccelerometer_16g

**Grove I2C 3-Axis digital accelerometer**

The **3-AxisDigitalAccelerometer_16g** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
ThreeAxisDigitalAccelerometer16g sensor;

public override Task Initialize()
{
    Console.WriteLine("Initializing");

    sensor = new ThreeAxisDigitalAccelerometer16g(Device.CreateI2cBus());
    sensor.SetPowerState(false, false, true, false, ThreeAxisDigitalAccelerometer16g.Frequencies.TwoHz);

    sensor.Updated += (sender, result) =>
    {
        Console.WriteLine($"Accel: [X:{result.New.X.MetersPerSecondSquared:N2}," +
            $"Y:{result.New.Y.MetersPerSecondSquared:N2}," +
            $"Z:{result.New.Z.MetersPerSecondSquared:N2} (m/s^2)]");
    };

    return Task.CompletedTask;
}

public override Task Run()
{
    sensor.StartUpdating(TimeSpan.FromMilliseconds(500));

    return Task.CompletedTask;
}

```

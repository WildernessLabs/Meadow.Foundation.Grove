# Meadow.Foundation.Grove.Sensors.Motion.3-AxisDigitalCompass

**Grove I2C 3-axis digital compass**

The **3-AxisDigitalCompass** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
ThreeAxisDigitalCompass sensor;

public override Task Initialize()
{
    Console.WriteLine("Initializing ...");

    sensor = new ThreeAxisDigitalCompass(Device.CreateI2cBus());

    sensor.Updated += (sender, result) => {
        Console.WriteLine($"Direction: [X:{result.New.X:N2}," +
            $"Y:{result.New.Y:N2}," +
            $"Z:{result.New.Z:N2}]");

        Console.WriteLine($"Heading: [{Hmc5883.DirectionToHeading(result.New).DecimalDegrees:N2}] degrees");
    };

    var consumer = Hmc5883.CreateObserver(
        handler: result =>
        {
            Console.WriteLine($"Observer: [x] changed by threshold; " +
                $"new [x]: X:{Hmc5883.DirectionToHeading(result.New):N2}, " +
                $"old: X:{((result.Old != null) ? Hmc5883.DirectionToHeading(result.Old.Value) : "n/a"):N2} degrees");
        },
        filter: result => {
            if (result.Old is { } old)
            { //c# 8 pattern match syntax. checks for !null and assigns var.
                return (Hmc5883.DirectionToHeading(result.New - old) > new Azimuth(5));
            }
            return false;
        });

    sensor.Subscribe(consumer);

    return Task.CompletedTask;
}

public override Task Run()
{
    sensor.StartUpdating(TimeSpan.FromSeconds(1));

    return Task.CompletedTask;
}

```

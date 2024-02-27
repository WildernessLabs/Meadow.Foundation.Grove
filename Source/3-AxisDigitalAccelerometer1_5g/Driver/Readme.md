# Meadow.Foundation.Grove.Sensors.Motion.3-AxisDigitalAccelerometer1_5g

**Grove I2C 3-Axis digital accelerometer**

The **3-AxisDigitalAccelerometer1_5g** library is included in the **Meadow.Foundation.Grove.Sensors.Motion.3-AxisDigitalAccelerometer1_5g** nuget package and is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform.

This driver is part of the [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/) peripherals library, an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT applications.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Installation

You can install the library from within Visual studio using the the NuGet Package Manager or from the command line using the .NET CLI:

`dotnet add package Meadow.Foundation.Grove.Sensors.Motion.3-AxisDigitalAccelerometer1_5g`
## Usage

```csharp
ThreeAxisDigitalAccelerometer1_5g sensor;

public override Task Initialize()
{
    Resolver.Log.Info("Initializing");

    // create the sensor driver
    sensor = new ThreeAxisDigitalAccelerometer1_5g(Device.CreateI2cBus());

    // classical .NET events can also be used:
    sensor.Updated += (sender, result) =>
    {
        Resolver.Log.Info($"Accel: [X:{result.New.X.MetersPerSecondSquared:N2}," +
            $"Y:{result.New.Y.MetersPerSecondSquared:N2}," +
            $"Z:{result.New.Z.MetersPerSecondSquared:N2} (m/s^2)]" +
            $" Direction: {sensor.Direction}" +
            $" Orientation: {sensor.Orientation}");
    };

    // Example that uses an IObersvable subscription to only be notified when the filter is satisfied
    var consumer = ThreeAxisDigitalAccelerometer1_5g.CreateObserver(
        handler: result => Resolver.Log.Info($"Observer: [x] changed by threshold; new [x]: X:{result.New.X:N2}, old: X:{result.Old?.X:N2}"),
        // only notify if there's a greater than 0.5G change in the Z direction
        filter: result =>
        {
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
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).
## About Meadow

Meadow is a complete, IoT platform with defense-grade security that runs full .NET applications on embeddable microcontrollers and Linux single-board computers including Raspberry Pi and NVIDIA Jetson.

### Build

Use the full .NET platform and tooling such as Visual Studio and plug-and-play hardware drivers to painlessly build IoT solutions.

### Connect

Utilize native support for WiFi, Ethernet, and Cellular connectivity to send sensor data to the Cloud and remotely control your peripherals.

### Deploy

Instantly deploy and manage your fleet in the cloud for OtA, health-monitoring, logs, command + control, and enterprise backend integrations.



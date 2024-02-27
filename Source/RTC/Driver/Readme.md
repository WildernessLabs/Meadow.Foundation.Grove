# Meadow.Foundation.Grove.RTCs.RTC

**Grove I2C real time clock (DS1307)**

The **RTC** library is included in the **Meadow.Foundation.Grove.RTCs.RTC** nuget package and is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform.

This driver is part of the [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/) peripherals library, an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT applications.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Installation

You can install the library from within Visual studio using the the NuGet Package Manager or from the command line using the .NET CLI:

`dotnet add package Meadow.Foundation.Grove.RTCs.RTC`
## Usage

```csharp
RTC rtc;

public override Task Initialize()
{
    Resolver.Log.Info("Initialize...");

    rtc = new RTC(Device.CreateI2cBus());

    return Task.CompletedTask;
}

public override Task Run()
{
    var running = rtc.IsRunning;

    Resolver.Log.Info($"{(running ? "is running" : "is not running")}");

    if (!running)
    {
        Resolver.Log.Info(" Starting RTC...");
        rtc.IsRunning = true;
    }

    var dateTime = rtc.GetTime();
    Resolver.Log.Info($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

    Resolver.Log.Info($" Setting RTC to : {dateTime:MM/dd/yy HH:mm:ss}");
    dateTime = new DateTime(2030, 2, 15);
    rtc.SetTime(dateTime);

    dateTime = rtc.GetTime();
    Resolver.Log.Info($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

    var rand = new Random();

    var data = new byte[56];

    for (int i = 0; i < 56; i++)
    {
        data[i] = (byte)rand.Next(256);
    }

    Resolver.Log.Info($" Writing to RTC RAM   : {BitConverter.ToString(data)}");
    rtc.WriteRAM(0, data);
    Resolver.Log.Info($" Reading from RTC RAM : ");
    data = rtc.ReadRAM(0, 56);
    Resolver.Log.Info(BitConverter.ToString(data));

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



# Meadow.Foundation.Grove.RTCs.RTC

**Grove I2C real time clock (DS1307)**

The **RTC** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
RTC rtc;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    rtc = new RTC(Device.CreateI2cBus());

    return Task.CompletedTask;
}

public override Task Run()
{
    var running = rtc.IsRunning;

    Console.WriteLine($"{(running ? "is running" : "is not running")}");

    if (!running)
    {
        Console.WriteLine(" Starting RTC...");
        rtc.IsRunning = true;
    }

    var dateTime = rtc.GetTime();
    Console.WriteLine($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

    Console.WriteLine($" Setting RTC to : {dateTime:MM/dd/yy HH:mm:ss}");
    dateTime = new DateTime(2030, 2, 15);
    rtc.SetTime(dateTime);

    dateTime = rtc.GetTime();
    Console.WriteLine($" RTC current time is: {dateTime:MM/dd/yy HH:mm:ss}");

    var rand = new Random();

    var data = new byte[56];

    for (int i = 0; i < 56; i++)
    {
        data[i] = (byte)rand.Next(256);
    }

    Console.WriteLine($" Writing to RTC RAM   : {BitConverter.ToString(data)}");
    rtc.WriteRAM(0, data);
    Console.Write($" Reading from RTC RAM : ");
    data = rtc.ReadRAM(0, 56);
    Console.WriteLine(BitConverter.ToString(data));

    return Task.CompletedTask;
}

```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).

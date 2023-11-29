# Meadow.Foundation.Grove.Relays.4ChannelSpdtRelay

**Grove I2C 4-Channel SPDT Relay**

The **4ChannelSpdtRelay** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
FourChannelSpdtRelay module;

public override Task Initialize()
{
    Resolver.Log.Info("Initializing ...");

    module = new FourChannelSpdtRelay(Device.CreateI2cBus(), 0x11);

    return Task.CompletedTask;
}

public override Task Run()
{
    for (int i = 0; i < 5; i++)
    {
        Resolver.Log.Info("All on");
        module.SetAllOn();

        Thread.Sleep(1000);

        Resolver.Log.Info("All off");
        module.SetAllOff();

        Thread.Sleep(1000);

        for (int j = 0; j < 4; j++)
        {
            Resolver.Log.Info($"{(RelayIndex)j} on");
            module.Relays[j].IsOn = true;
            Thread.Sleep(1000);
        }

        for (int j = 0; j < 4; j++)
        {
            Resolver.Log.Info($"{(RelayIndex)j} off");
            module.Relays[j].IsOn = false;
            Thread.Sleep(1000);
        }
    }

    return Task.CompletedTask;
}

```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).

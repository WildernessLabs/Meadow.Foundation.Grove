# Meadow.Foundation.Grove.Relays.Relay

**Grove Relay driver**

The **Relay** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
Relay relay;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            relay = new Relay(Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            var state = false;

            while (true)
            {
                state = !state;

                Resolver.Log.Info($"- State: {state}");

                relay.State = state
          ? Meadow.Peripherals.Relays.RelayState.Closed
          : Meadow.Peripherals.Relays.RelayState.Open;

                await Task.Delay(500);
            }
        }

        
```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).

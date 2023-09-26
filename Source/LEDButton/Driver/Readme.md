# Meadow.Foundation.Grove.Sensors.Buttons.LEDButton

**Grove GPIO momentary push button with LED (blue, red, or yellow)**

The **LEDButton** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
LEDButton ledButton;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    ledButton = new LEDButton(buttonPin: Device.Pins.D12, ledPin: Device.Pins.D13);

    ledButton.LongClickedThreshold = TimeSpan.FromMilliseconds(1500);

    ledButton.Clicked += (s, e) =>
    {
        Console.WriteLine("Grove Button clicked");
        ledButton.IsLedOn = !ledButton.IsLedOn;
    };

    ledButton.LongClicked += (s, e) =>
    {
        Console.WriteLine("Grove Button long clicked");
    };

    return Task.CompletedTask;
}

```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).

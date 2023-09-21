# Meadow.Foundation.Grove.Audio.Buzzer

**Grove PWM Buzzer**

The **Buzzer** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
Buzzer buzzer;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    buzzer = new Buzzer(Device.Pins.D13);

    return Task.CompletedTask;
}

public override async Task Run()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Playing A major triad starting at A4");
        await buzzer.PlayTone(new Frequency(440, Frequency.UnitType.Hertz), TimeSpan.FromMilliseconds(500)); //A
        await buzzer.PlayTone(new Frequency(554.37f, Frequency.UnitType.Hertz), TimeSpan.FromMilliseconds(500)); //C#
        await buzzer.PlayTone(new Frequency(659.25f, Frequency.UnitType.Hertz), TimeSpan.FromMilliseconds(500)); //E

        await Task.Delay(2500);
    }
}

```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).

# Meadow.Foundation.Grove.Servos.Servo

**Grove PWM servo motor**

The **Servo** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
Servo servo;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    servo = new Servo(Device.Pins.D13);

    return Task.CompletedTask;
}

public override async Task Run()
{
    await servo.RotateTo(new Angle(servo.Config.MinimumAngle.Degrees, AU.Degrees));

    while (true)
    {
        for (int i = 0; i <= servo.Config.MaximumAngle.Degrees; i++)
        {
            await servo.RotateTo(new Angle(i, AU.Degrees));
            Console.WriteLine($"Rotating to {i}");
            await Task.Delay(40);
        }

        await Task.Delay(2000);
        
        for (int i = 180; i >= servo.Config.MinimumAngle.Degrees; i--)
        {
            await servo.RotateTo(new Angle(i, AU.Degrees));
            Console.WriteLine($"Rotating to {i}");
            await Task.Delay(40);
        }

        await Task.Delay(2000);
    }
}

```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).

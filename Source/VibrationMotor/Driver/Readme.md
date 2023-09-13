# Meadow.Foundation.Grove.HID.VibrationMotor

**Grove GPIO vibration motor**

The **VibrationMotor** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/)

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/), to view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/)

## Usage

```
VibrationMotor vibrationMotor;

public override Task Initialize()
{
    Console.WriteLine("Initialize...");

    vibrationMotor = new VibrationMotor(Device.Pins.D13);

    return Task.CompletedTask;
}

public override async Task Run()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Motor on");
        vibrationMotor.IsVibrating = true;
        await Task.Delay(1000);

        Console.WriteLine("Motor off");
        vibrationMotor.IsVibrating = false;
        await Task.Delay(1000);
    }
}

```

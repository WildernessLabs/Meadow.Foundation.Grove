using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using Meadow.Units;
using System;
using System.Threading.Tasks;
using AU = Meadow.Units.Acceleration.UnitType;

namespace Grove.ThreeAxisDigitalAcceleromter1_5g_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        ThreeAxisDigitalAccelerometer1_5g sensor;

        public override Task Initialize()
        {
            Console.WriteLine("Initializing");

            // create the sensor driver
            var sensor = new ThreeAxisDigitalAccelerometer1_5g(Device.CreateI2cBus());

            // classical .NET events can also be used:
            sensor.Updated += (sender, result) => {
                Console.WriteLine($"Accel: [X:{result.New.X.MetersPerSecondSquared:N2}," +
                    $"Y:{result.New.Y.MetersPerSecondSquared:N2}," +
                    $"Z:{result.New.Z.MetersPerSecondSquared:N2} (m/s^2)]" +
                    $" Direction: {sensor.Direction}" +
                    $" Orientation: {sensor.Orientation}");
            };

            // Example that uses an IObersvable subscription to only be notified when the filter is satisfied
            var consumer = ThreeAxisDigitalAccelerometer1_5g.CreateObserver(
                handler: result => Console.WriteLine($"Observer: [x] changed by threshold; new [x]: X:{result.New.X:N2}, old: X:{result.Old?.X:N2}"),
                // only notify if there's a greater than 0.5G change in the Z direction
                filter: result => {
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

        //<!=SNOP=>
    }
}
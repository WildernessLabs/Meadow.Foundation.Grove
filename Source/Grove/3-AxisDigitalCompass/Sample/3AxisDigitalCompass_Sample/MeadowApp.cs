using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Displays;
using Meadow.Foundation.Sensors.Motion;
using Meadow.Units;
using System;

namespace Grove.ThreeAxisDigitalCompass_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initializing ...");

            var sensor = new ThreeAxisDigitalCompass(Device.CreateI2cBus());

            // classical .NET events can also be used:
            sensor.Updated += (sender, result) => {
                Console.WriteLine($"Direction: [X:{result.New.X:N2}," +
                    $"Y:{result.New.Y:N2}," +
                    $"Z:{result.New.Z:N2}]");

                Console.WriteLine($"Heading: [{Hmc5883.DirectionToHeading(result.New).DecimalDegrees:N2}] degrees");
            };

            // Example that uses an IObersvable subscription to only be notified when the filter is satisfied
            var consumer = Hmc5883.CreateObserver(
                handler: result => Console.WriteLine($"Observer: [x] changed by threshold; new [x]: X:{Hmc5883.DirectionToHeading(result.New):N2}," +
                        $" old: X:{((result.Old != null) ? Hmc5883.DirectionToHeading(result.Old.Value) : "n/a"):N2} degrees"),
                // only notify if there's a greater than 5° of heading change
                filter: result => {
                    if (result.Old is { } old)
                    { //c# 8 pattern match syntax. checks for !null and assigns var.
                        return (Hmc5883.DirectionToHeading(result.New - old) > new Azimuth(5));
                    }
                    return false;
                });

            sensor.Subscribe(consumer);

            // start updating
            sensor.StartUpdating(TimeSpan.FromMilliseconds(1000));

        }
    }
}
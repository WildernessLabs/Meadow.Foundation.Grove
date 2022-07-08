using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using System;
using System.Threading.Tasks;

namespace Grove.FourDigitDisplay_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        ThreeAxisDigitalAccelerometer16g sensor;

        public override Task Initialize()
        {
            Console.WriteLine("Initializing");

            var sensor = new ThreeAxisDigitalAccelerometer16g(Device.CreateI2cBus());
            sensor.SetPowerState(false, false, true, false, ThreeAxisDigitalAccelerometer16g.Frequencies.TwoHz);

            sensor.Updated += (sender, result) =>
            {
                Console.WriteLine($"Accel: [X:{result.New.X.MetersPerSecondSquared:N2}," +
                    $"Y:{result.New.Y.MetersPerSecondSquared:N2}," +
                    $"Z:{result.New.Z.MetersPerSecondSquared:N2} (m/s^2)]");
            };

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            sensor.StartUpdating(TimeSpan.FromMilliseconds(500));

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using Meadow.Foundation.Sensors.Motion;
using Meadow.Units;
using System;
using System.Threading.Tasks;

namespace Grove.ThreeAxisDigitalCompass_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        ThreeAxisDigitalCompass sensor;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initializing ...");

            sensor = new ThreeAxisDigitalCompass(Device.CreateI2cBus());

            sensor.Updated += (sender, result) =>
            {
                Resolver.Log.Info($"Direction: [X:{result.New.X:N2}," +
                    $"Y:{result.New.Y:N2}," +
                    $"Z:{result.New.Z:N2}]");

                Resolver.Log.Info($"Heading: [{Hmc5883.DirectionToHeading(result.New).DecimalDegrees:N2}] degrees");
            };

            var consumer = Hmc5883.CreateObserver(
                handler: result =>
                {
                    Resolver.Log.Info($"Observer: [x] changed by threshold; " +
                        $"new [x]: X:{Hmc5883.DirectionToHeading(result.New):N2}, " +
                        $"old: X:{((result.Old != null) ? Hmc5883.DirectionToHeading(result.Old.Value) : "n/a"):N2} degrees");
                },
                filter: result =>
                {
                    if (result.Old is { } old)
                    { //c# 8 pattern match syntax. checks for !null and assigns var.
                        return (Hmc5883.DirectionToHeading(result.New - old) > new Azimuth(5));
                    }
                    return false;
                });

            sensor.Subscribe(consumer);

            return Task.CompletedTask;
        }

        public override Task Run()
        {
            sensor.StartUpdating(TimeSpan.FromSeconds(1));

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}
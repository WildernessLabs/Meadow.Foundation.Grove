﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Moisture;
using System;
using System.Threading.Tasks;

namespace MoistureSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        MoistureSensor sensor;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            sensor = new MoistureSensor(Device.Pins.A01);

            var consumer = MoistureSensor.CreateObserver(
                handler: result => Resolver.Log.Info($"Observer filter satisfied: {result.New.Millivolts:N2}mV, old: {result.Old?.Millivolts:N2}mV"),
                filter: result =>
                {
                    if (result.Old is { } old)
                    { //c# 8 pattern match syntax. checks for !null and assigns var.
                        return (result.New - old).Abs().Millivolts > 500;
                    }
                    return false;
                });
            sensor.Subscribe(consumer);

            // classical .NET events can also be used:
            sensor.Updated += (sender, result) =>
            {
                Resolver.Log.Info($"Voltage Changed, new: {result.New.Millivolts:N2}mV, old: {result.Old?.Millivolts:N2}mV");
            };

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            var result = await sensor.Read();
            Resolver.Log.Info($"Initial read: {result.Millivolts:N2}mV");

            sensor.StartUpdating(TimeSpan.FromMilliseconds(1000));
        }

        //<!=SNOP=>
    }
}
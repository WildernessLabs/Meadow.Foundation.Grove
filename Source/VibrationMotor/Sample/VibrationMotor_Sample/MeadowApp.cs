﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.HID;
using System;
using System.Threading.Tasks;

namespace Grove.VibrationMotor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        VibrationMotor vibrationMotor;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initialize...");

            vibrationMotor = new VibrationMotor(Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Resolver.Log.Info("Motor on");
                vibrationMotor.IsVibrating = true;
                await Task.Delay(1000);

                Resolver.Log.Info("Motor off");
                vibrationMotor.IsVibrating = false;
                await Task.Delay(1000);
            }
        }

        //<!=SNOP=>
    }
}
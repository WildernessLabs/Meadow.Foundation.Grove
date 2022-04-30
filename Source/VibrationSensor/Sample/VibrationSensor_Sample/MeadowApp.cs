using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Motion;
using System;

namespace Grove.VibrationSensor_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var vibrationSensor = new VibrationSensor(Device, Device.Pins.D13);

            vibrationSensor.VibrationDetected += (s, e) => 
            { 
                Console.WriteLine("Motion detected"); 
            };
        }

        //<!=SNOP=>
    }
}